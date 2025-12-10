{
  deps,
  pkgs,
  dotnet-sdk,
  nix-gitignore,
  dotnet-runtime,
  buildDotnetModule,
  version,
}:
let
  name = "Spent";
in
buildDotnetModule {
  pname = name;
  inherit dotnet-sdk dotnet-runtime version;

  src = nix-gitignore.gitignoreSource [ ] ../.;
  projectFile = "src/Spent.fsproj";
  dotnetRestoreFlags = "--force-evaluate";

  nugetDeps = deps {
    pkgs = pkgs;
    name = name;
    lockfiles = [
      ./packages.lock.json
      ./GraphQL/packages.lock.json
    ];
  };

  doCheck = false;
}
