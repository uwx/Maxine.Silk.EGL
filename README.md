# Maxine.Silk.EGL

[EGL](https://registry.khronos.org/EGL/) bindings for C#, plus prebuilt
[ANGLE](https://chromium.googlesource.com/angle/angle/) binaries to run them on.

EGL is the Khronos API that sits below OpenGL and OpenGL ES: it creates contexts and surfaces
(window, pbuffer, or headless) independently of any windowing toolkit. It is the practical route to
offscreen rendering, and the only portable way to get a GL/GLES context on Linux or Android without
going through a windowing library.

These packages are companions to [Silk.NET](https://github.com/dotnet/Silk.NET) 2.x and target the
same frameworks, so they can be referenced alongside `Silk.NET.OpenGL`, `Silk.NET.OpenGLES` and
friends.

The packages sit under a `Maxine.Silk.` prefix but the C# namespaces do not: the generated code
refers to `Silk.NET.Core` types by their full name without a `using`, so a namespace with a `Silk`
segment in it would shadow that and fail to compile. `using Maxine.EGL;` is the namespace; install
`Maxine.Silk.EGL`.

## Packages

| Package | Contents |
|---|---|
| `Maxine.Silk.EGL` | Core EGL bindings (`EGL.GetApi()`, enums, overloads) |
| `Maxine.Silk.EGL.Extensions.*` | One package per extension vendor: `EXT`, `NV`, `KHR`, `ANDROID`, `ANGLE`, `ARM`, `HI`, `IMG`, `MESA`, `NOK`, `QNX`, `TIZEN`, `WL` |
| `Maxine.Silk.OpenGLES.ANGLE.Native` | Prebuilt ANGLE `libEGL` / `libGLESv2` for `win-x64`, `win-x86`, `win-arm64`, `linux-x64`, `linux-arm64` and `osx` (universal, x86_64 + arm64) |

## Usage

```csharp
using Maxine.EGL;

using var egl = EGL.GetApi();

// Extensions resolve through eglGetProcAddress.
if (egl.TryGetExtension<KhrDebug>(out var debug))
{
    // ...
}
```

`Maxine.EGL` resolves `libEGL.so.1` on Linux, `libEGL.so` on Android, `libEGL.dll` on Windows, and the
`EGL.framework` path on macOS. To use the bundled ANGLE build instead of a system EGL, reference
`Maxine.Silk.OpenGLES.ANGLE.Native` — its targets copy the right binaries next to your application, and
ANGLE's `libEGL` is what gets loaded.

Note that ANGLE, like EGL itself, has no macOS system framework; the `osx` binaries are a
self-contained ANGLE build and are what you want on that platform.

## Repository layout

```
src/Maxine.EGL/            Core bindings (generated + hand-written)
src/Extensions/           One project per extension vendor
native/                   ANGLE native package and its committed binaries
build/                    Type maps, generator cache, licence header
tools/SilkGenerate/       Runs Silk.NET.BuildTools over generator.json
build/nuke/               NUKE build: the `Angle` target
```

## Regenerating the bindings

The `*.gen.cs` files are generated from the Khronos EGL registry by
[Silk.NET.BuildTools](https://www.nuget.org/packages/Silk.NET.BuildTools), which is consumed as an
ordinary NuGet package — there is no copy of it in this repository.

```bash
dotnet run --project tools/SilkGenerate -- generator.json            # everything
dotnet run --project tools/SilkGenerate -- generator.json --profile=EGL
```

At build time the generated sources are compiled by
[Silk.NET.SilkTouch](https://www.nuget.org/packages/Silk.NET.SilkTouch), which implements the
`partial` methods. Its options live in `.editorconfig` at the repository root.

Files that are **not** generated — `src/Maxine.EGL/EGL.cs`, `PfnDebugProcKhr.cs`,
`PfnGetBlobFuncANDROID.cs`, `PfnSetBlobFuncANDROID.cs` and `ClientPixmapHI.cs` — are deliberately
not named `*.gen.cs`, because the generator deletes stale files that match that pattern.

## Building the ANGLE binaries

ANGLE is fetched and built from source by the `Angle` NUKE target, which needs no checkout of ANGLE:

```bash
./build.sh Angle        # Linux / macOS
./build.cmd Angle       # Windows
```

Each platform builds what it can: Windows produces x64 (and x86, on an x64 host), Linux produces x64
and cross-compiles arm64, and macOS builds both architectures and merges them into a universal binary
with `lipo`. Results are written to `native/Maxine.Silk.OpenGLES.ANGLE.Native/runtimes/<rid>/native/`,
where the NuGet package picks them up.

Set `SILKNET_EGL_TARGET_CPU=arm64` on an x64 Linux host to cross-compile for arm64, which is what CI
does. Building on an arm64 Linux host does not work: Chromium publishes no arm64 clang for Linux, so
the build downloads an x64 one and fails to execute it.

The `.github/workflows/angle.yml` job runs this on all three platforms and commits the binaries back
onto the branch. Locally the result is left in the working tree for inspection; set
`SILKNET_EGL_PUBLISH=1` to commit and push it from a local run too.

## Licence

The bindings are MIT, matching Silk.NET — see [LICENSE.md](LICENSE.md). The ANGLE binaries in
`Maxine.Silk.OpenGLES.ANGLE.Native` are BSD-3-Clause, as ANGLE is.
