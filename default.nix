{
  sources ? import ./npins,
  pkgs ? import sources.nixpkgs { },
}:
let
  snowflaqe = pkgs.buildDotnetGlobalTool (finalAttrs: {
    pname = "snowflaqe";
    version = "1.48.0";

    nugetHash = "sha256-2VSOY3OecRWVWBjWX7Dlba04Iy7Ag84+mBS3vxuxNGk=";
  });

in
{
  shell = pkgs.mkShell {
    packages = with pkgs; [
      npins

      snowflaqe
      dotnetCorePackages.sdk_10_0
    ];
  };
}
