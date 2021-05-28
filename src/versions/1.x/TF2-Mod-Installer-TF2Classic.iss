#define MyAppName "TF2 Classic Installer"
#define MyAppVersion "2.0.2"
#define MyAppPublisher "TheCrafters001"
#define MyAppURL "http://thecrafters001.github.io/"
#define SourceModFolder "{autopf}\Steam\steamapps\sourcemods"

[Setup]
AppId={{1131E14B-70D8-4B92-A0B8-362B3CAD94D4}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL=https://tf2classic.com/
AppSupportURL=https://tf2classic.com/
AppUpdatesURL=https://tf2classic.com/
DefaultDirName={#SourceModFolder}
DefaultGroupName=TF2 Classic
DisableProgramGroupPage=yes
DisableWelcomePage=False
LicenseFile=.\TF2Classic.rtf
OutputDir=.\
OutputBaseFilename=TF2-Classic_Installer
Compression=lzma
SolidCompression=yes
WizardStyle=modern
WizardImageFile=.\assets\TF2C_InstallWizard.bmp
WizardSmallImageFile=.\assets\ModInstallerWizardSmall.bmp
AllowCancelDuringInstall=no
                                                                                  ; https://drive.google.com/uc?export=download&id=1lrDTkx6Qjq0KafAOrvTsZ4fUQjvuuC6D
[Files]
;7-Zip
Source: "Utilities\7Zip\7za.dll"; DestDir: "{tmp}"; Flags: ignoreversion deleteafterinstall
Source: "Utilities\7Zip\7za.exe"; DestDir: "{tmp}"; Flags: ignoreversion deleteafterinstall
Source: "Utilities\7Zip\7zxa.dll"; DestDir: "{tmp}"; Flags: ignoreversion deleteafterinstall
; Source: "Utilities\scripts\tf2Classic_Install.bat"; DestDir: "{tmp}"; Flags: ignoreversion deleteafterinstall
;TF2-Classic
Source: "{tmp}\tf2classic.exe"; \
    DestDir: "{tmp}"; \
    Flags: external deleteafterinstall; \
    Components: full; \
    Check: DwinsHs_Check(ExpandConstant('{tmp}\tf2classic.exe'),  'https://files.moevsmachine.tf/tf2classic_full_2-0-2.exe', 'TF2 Mods', 'get', 0, 0)

; Patched VIP_badwater map
Source: "{tmp}\vip_badwater.bsp"; \
    DestDir: "{tmp}"; \
    Flags: external deleteafterinstall; \
    Components: full; \
    Check: DwinsHs_Check(ExpandConstant('{tmp}\vip_badwater.bsp'),  'https://drive.google.com/uc?export=download&id=1lrDTkx6Qjq0KafAOrvTsZ4fUQjvuuC6D', 'TF2 Mods', 'get', 0, 0)

[Run]
Filename: "{tmp}\7za.exe"; Parameters: "x ""{tmp}\tf2classic.exe"" -o""{#SourceModFolder}\"" * -r -aoa -y"; Flags: runhidden; Description: "Team Fortress 2 Classic"; StatusMsg: "Installing Team Fortress 2 Classic... This may take a while..."
Filename: "cmd"; Parameters: "/c copy /y ""{tmp}\vip_badwater.bsp"" ""{#SourceModFolder}\tf2classic\maps\"""; Description: "Patches vip_badwater"; StatusMsg: "Patching vip_badwater...";

[Components]
Name: "full"; Description: "Team Fortress 2 Classic"; ExtraDiskSpaceRequired: 3700000000; Types: main; Flags: fixed

[Types]
Name: "main"; Description: "Full Install"

[UninstallDelete]
Type: filesandordirs; Name: "{#SourceModFolder}\tf2classic"

[Messages]
BeveledLabel=Team Fortress 2 Classic Installer
WelcomeLabel1=Thank you for downloading the [name]!
WelcomeLabel2=[name] allows you to install TF2 Classic easily!%n%nPlease make sure TF2 is closed, Source SDK 2013 Multiplayer is installed, and that Steam is completely closed.
ClickNext=Click Next to continue, or Cancel to exit.
SetupWindowTitle=%1
UninstallAppFullTitle=Uninstall TF2 Classic
UninstallAppTitle=Uninstall TF2 Classic
UninstalledAll=Uninstalled TF2 Classic successfully
UninstallStatusLabel=Please wait while TF2 Classic is being uninstalled.
ConfirmUninstall=Are you sure you want to uninstall TF2 Classic? This will NOT affect your current copy of TF2.
SelectComponentsDesc=Select Full Install
SelectComponentsLabel2=Select Full Install to install TF2 Classic
WizardSelectComponents=Select TF2 Classic Install Type
WizardUninstalling=Removing TF2 Classic...
WizardInstalling=Installing TF2 Classic...
InstallingLabel=Please wait while TF2 Classic gets installed... This may take some time...
SelectDirDesc=Where do you want to install TF2 Classic?
SelectDirLabel3=I will put the mods in the following folder.
SelectDirBrowseLabel=Once you have selected the folder you want to install TF2 Classic, click Next. (Default Recommended)
ReadyLabel1=I have gathered all the info I needed! Ready to install TF2 Classic! :D
StatusExtractFiles=Copying files...
StatusUninstalling=Removing TF2 Classic...
ShutdownBlockReasonUninstallingApp=Removing TF2 Classic...
FinishedLabelNoIcons=TF2 Classic is now installed!
FinishedLabel=TF2 Classic is now installed!
FinishedHeadingLabel=Done installing TF2 Classic!

[Code]
#define DwinsHs_Use_Predefined_Downloading_WizardPage
#define DwinsHs_Auto_Continue
#include "./Utilities/DwinsHs/dwinshs.iss"

procedure InitializeWizard();
begin
  DwinsHs_InitializeWizard(wpPreparing);
end;

procedure CurPageChanged(CurPageID: Integer);
begin
  DwinsHs_CurPageChanged(CurPageID, nil, nil);
end;

function ShouldSkipPage(CurPageId: Integer): Boolean;
begin
  Result := False;
  DwinsHs_ShouldSkipPage(CurPageId, Result);
end;

function BackButtonClick(CurPageID: Integer): Boolean;
begin
  Result := True;
  DwinsHs_BackButtonClick(CurPageID);
end;

function NextButtonClick(CurPageID: Integer): Boolean;
begin
  Result := True;
  DwinsHs_NextButtonClick(CurPageID, Result);
end;

procedure CancelButtonClick(CurPageID: Integer; var Cancel, Confirm: Boolean);
begin
  DwinsHs_CancelButtonClick(CurPageID, Cancel, Confirm);
end;
