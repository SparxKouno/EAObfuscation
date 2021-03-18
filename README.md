# EAObfuscation

Data obfuscation tool for Sparx Systems Enterprise Architect (EA) EAP/EAPX files.

By applying this tool to your EA project file, model-specific data like various kind of Names, Notes are replaced to meaningless strings. When you need to offer project files to the support team but you do not want to open the model to the team, use this tool.

## How to Build

To build this tool, open the sln file with Visual Studio 2019 and build as Release build.

In the build directory, you can download the executable.

## How to Use

Launch this tool and select the target project file. Now .eap and .eapx files are supported. When you press the Run button, this tool will create a backup file and then apply obfuscation to the backup file. So, the target file will not be changed.

Open the obfuscatated file with Enterprise Architect to check if it works correctly.

