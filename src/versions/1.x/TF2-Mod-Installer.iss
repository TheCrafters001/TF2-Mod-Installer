; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "TF2 Mod Installer"
#define MyAppVersion "1.9"
#define MyAppPublisher "TheCrafters001"
#define MyAppURL "http://thecrafters001.github.io/"

#define MediaPath "{autopf}\Steam\steamapps\common\Team Fortress 2\tf\media"

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{1B652402-F1DA-41CB-9ECD-200FB9045521}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\Steam\steamapps\common\Team Fortress 2\tf\custom
DefaultGroupName=TF2 Mods
DisableProgramGroupPage=yes
LicenseFile=.\gpl-3.0.rtf
; Uncomment the following line to run in non administrative install mode (install for current user only.)
;PrivilegesRequired=lowest
OutputDir=.\
OutputBaseFilename=TF2-Mod-Installer
Compression=lzma
SolidCompression=yes
WizardStyle=modern
DisableWelcomePage=False
InfoBeforeFile=.\Note.txt
WizardImageFile=assets\ModInstallerWizard.bmp
WizardSmallImageFile=assets\ModInstallerWizardSmall.bmp
UninstallDisplayName=TF2 Mods from TF2 Mod Installer
WindowVisible=True
WindowResizable=False
WindowShowCaption=False

[Files]
;7-Zip
Source: "Utilities\7Zip\7za.dll"; DestDir: "{tmp}"; Flags: ignoreversion deleteafterinstall
Source: "Utilities\7Zip\7za.exe"; DestDir: "{tmp}"; Flags: ignoreversion deleteafterinstall
Source: "Utilities\7Zip\7zxa.dll"; DestDir: "{tmp}"; Flags: ignoreversion deleteafterinstall
;Huds
Source: "{tmp}\TFPlus.zip"; \
    DestDir: "{tmp}"; \
    Flags: external deleteafterinstall; \
    Components: HUDs/TFPlus; \
    Check: DwinsHs_Check(ExpandConstant('{tmp}\TFPlus.zip'),  'https://github.com/SnowshoeIceboot/tf2hudplus/archive/master.zip', 'TF2 Mods', 'get', 0, 0)
Source: "{tmp}\rayshud.zip"; \
    DestDir: "{tmp}"; \
    Flags: external deleteafterinstall; \
    Components: HUDs/rayshud; \
    Check: DwinsHs_Check(ExpandConstant('{tmp}\rayshud.zip'),  'https://github.com/raysfire/rayshud/archive/master.zip', 'TF2 Mods', 'get', 0, 0)
Source: "{tmp}\FlawHUD.zip"; \
    DestDir: "{tmp}"; \
    Flags: external deleteafterinstall; \
    Components: HUDs/flawhud; \
    Check: DwinsHs_Check(ExpandConstant('{tmp}\FlawHUD.zip'),  'https://github.com/CriticalFlaw/FlawHUD/archive/master.zip', 'TF2 Mods', 'get', 0, 0)
Source: "{tmp}\ahud.zip"; \
    DestDir: "{tmp}"; \
    Flags: external deleteafterinstall; \
    Components: HUDs/ahud; \
    Check: DwinsHs_Check(ExpandConstant('{tmp}\ahud.zip'),  'https://github.com/n0kk/ahud/archive/master.zip', 'TF2 Mods', 'get', 0, 0)
Source: "{tmp}\toonhud.zip"; \
    DestDir: "{tmp}"; \
    Flags: external deleteafterinstall; \
    Components: HUDs/toonhud; \
    Check: DwinsHs_Check(ExpandConstant('{tmp}\toonhud.zip'),  'https://github.com/TheCrafters001/TF2-Mod-Installer/releases/download/1.9/toonhud.zip', 'TF2 Mods', 'get', 0, 0)
Source: "{tmp}\budhud.zip"; \
    DestDir: "{tmp}"; \
    Flags: external deleteafterinstall; \
    Components: HUDs/budhud; \
    Check: DwinsHs_Check(ExpandConstant('{tmp}\budhud.zip'),  'https://github.com/rbjaxter/budhud/archive/master.zip', 'TF2 Mods', 'get', 0, 0)

;Misc
Source: "{tmp}\TinyDeskEngie.zip"; \
    DestDir: "{tmp}"; \
    Flags: external deleteafterinstall; \
    Components: ModelReplace/TinyDeskEngie; \
    Check: DwinsHs_Check(ExpandConstant('{tmp}\TinyDeskEngie.zip'),  'https://files.gamebanana.com/skins/tiny_desk_engineers.zip', 'TF2 Mods', 'get', 0, 0)
Source: "{tmp}\valveNew.zip"; \
    DestDir: "{tmp}"; \
    Flags: external deleteafterinstall; \
    Components: MiscMods/ValveNew; \
    Check: DwinsHs_Check(ExpandConstant('{tmp}\valveNew.zip'),  'https://files.gamebanana.com/guis/open_your_mind_2.zip', 'TF2 Mods', 'get', 0, 0)
Source: "{tmp}\RoboHeavy.zip"; \
    DestDir: "{tmp}"; \
    Flags: external deleteafterinstall; \
    Components: ModelReplace ModelReplace/RoboHeavy; \
    Check: DwinsHs_Check(ExpandConstant('{tmp}\RoboHeavy.zip'),  'https://files.gamebanana.com/skins/robot_heavy_sentry.zip', 'TF2 Mods', 'get', 0, 0)
Source: ".\TF2-Classic_Installer.exe"; DestDir: "{tmp}"; Flags: deleteafterinstall; Components: MiscMods/LargeMods/TF2Classic

;Animation Overhauls
;Scout
Source: "{tmp}\scout.zip"; \
    DestDir: "{tmp}"; \
    Flags: external deleteafterinstall; \
    Components: AnimOver/Far/ScoutFar AnimOver/Close/ScoutClose; \
    Check: DwinsHs_Check(ExpandConstant('{tmp}\scout.zip'),  'https://files.gamebanana.com/skins/scoutoverhaulv3_34f0b.zip', 'TF2 Mods', 'get', 0, 0)
Source: "{tmp}\scout_alien.zip"; \
    DestDir: "{tmp}"; \
    Flags: external deleteafterinstall; \
    Components: ModelReplace/ScoutAlien; \
    Check: DwinsHs_Check(ExpandConstant('{tmp}\scout_alien.zip'),  'https://files.gamebanana.com/skins/scout_alien_hands_8d0e5.zip', 'TF2 Mods', 'get', 0, 0)
;Pyro
Source: "{tmp}\pyro.zip"; \
    DestDir: "{tmp}"; \
    Flags: external deleteafterinstall; \
    Components: AnimOver/Pyro; \
    Check: DwinsHs_Check(ExpandConstant('{tmp}\pyro.zip'),  'https://files.gamebanana.com/skins/kyle_s_pyro_fps_overhaul_v1.zip', 'TF2 Mods', 'get', 0, 0)
;Demoman
Source: "{tmp}\demoman.zip"; \
    DestDir: "{tmp}"; \
    Flags: external deleteafterinstall; \
    Components: AnimOver/Far/DemoFar AnimOver/Close/DemoClose; \
    Check: DwinsHs_Check(ExpandConstant('{tmp}\demoman.zip'),  'https://files.gamebanana.com/skins/demo_fp_anims.zip', 'TF2 Mods', 'get', 0, 0)
;Heavy
Source: "{tmp}\heavy.zip"; \
    DestDir: "{tmp}"; \
    Flags: external deleteafterinstall; \
    Components: AnimOver/Close/HeavyClose AnimOver/Far/HeavyFar; \
    Check: DwinsHs_Check(ExpandConstant('{tmp}\heavy.zip'),  'https://files.gamebanana.com/skins/heavyfpoverhaulv3-1-1_8a3e9.zip', 'TF2 Mods', 'get', 0, 0)
Source: "{tmp}\soviet_standoff.zip"; \
    DestDir: "{tmp}"; \
    Flags: external deleteafterinstall; \
    Components: AnimOver/Soviet_Stand_off; \
    Check: DwinsHs_Check(ExpandConstant('{tmp}\soviet_standoff.zip'), 'https://files.gamebanana.com/skins/heavy_s_bizarre_adventure_taunt_mod.zip', 'TF2 Mods', 'get', 0, 0)
;Engineer
Source: "{tmp}\engineer.zip"; \
    DestDir: "{tmp}"; \
    Flags: external deleteafterinstall; \
    Components: AnimOver/Far/EngineerFar AnimOver/Close/EngineerClose; \
    Check: DwinsHs_Check(ExpandConstant('{tmp}\engineer.zip'),  'https://files.gamebanana.com/skins/engineer-fp-ovhl-3-1.zip', 'TF2 Mods', 'get', 0, 0)
;Sniper
Source: "{tmp}\sniper.zip"; \
    DestDir: "{tmp}"; \
    Flags: external deleteafterinstall; \
    Components: AnimOver/Sniper; \
    Check: DwinsHs_Check(ExpandConstant('{tmp}\sniper.zip'),  'https://files.gamebanana.com/skins/sniperfpoverhaulv4.zip', 'TF2 Mods', 'get', 0, 0)

;Model Replacer
Source: "{tmp}\scoutLucario.zip"; \
    DestDir: "{tmp}"; \
    Flags: external deleteafterinstall; \
    Components: ModelReplace/scout_lucario; \
    Check: DwinsHs_Check(ExpandConstant('{tmp}\scoutLucario.zip'),  'https://files.gamebanana.com/skins/lucarioscout_2.zip', 'TF2 Mods', 'get', 0, 0)
;Sound Changes
Source: "{tmp}\PaTQMusic.zip"; \
    DestDir: "{tmp}"; \
    Flags: external deleteafterinstall; \
    Components: MiscMods/SoundMods/PeaceandTranquilQueue; \
    Check: DwinsHs_Check(ExpandConstant('{tmp}\PaTQMusic.zip'),  'https://files.gamebanana.com/sounds/tranquilqueue.zip', 'TF2 Mods', 'get', 0, 0)
Source: "{tmp}\spyward.zip"; \
    DestDir: "{tmp}"; \
    Flags: external deleteafterinstall; \
    Components: MiscMods/SoundMods/SpyWard; \
    Check: DwinsHs_Check(ExpandConstant('{tmp}\spyward.zip'),  'https://files.gamebanana.com/sounds/spyward_v4.zip', 'TF2 Mods', 'get', 0, 0)
Source: "{tmp}\Spongebob_Overtime.zip"; \
    DestDir: "{tmp}"; \
    Flags: external deleteafterinstall; \
    Components: MiscMods/SoundMods\Spongebob_Overtime; \
    Check: DwinsHs_Check(ExpandConstant('{tmp}\Spongebob_Overtime.zip'),  'https://files.gamebanana.com/sounds/spongebob_overtime_.zip', 'TF2 Mods', 'get', 0, 0)
Source: "{tmp}\snatcher.zip"; \
    DestDir: "{tmp}"; \
    Flags: external deleteafterinstall; \
    Components: MiscMods/SoundMods/Snatcher; \
    Check: DwinsHs_Check(ExpandConstant('{tmp}\snatcher.zip'),  'https://files.gamebanana.com/sounds/snatcherannouncer_aefc7.zip', 'TF2 Mods', 'get', 0, 0)

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Types]
Name: "custom"; Description: "Custom Mod Selection"; Flags: iscustom
Name: "viewmodel_far"; Description: "Install all available viewmodels (70+ FOV)"
Name: "viewmodel_close"; Description: "Install all available viewmodels (54 FOV)"

[Components]
;Huds
Name: "HUDs"; Description: "HUDs"
Name: "HUDs/TFPlus"; Description: "TF2 Hud Plus"; ExtraDiskSpaceRequired: 358920
Name: "HUDs/rayshud"; Description: "rayshud"; ExtraDiskSpaceRequired: 5270000
Name: "HUDs/FlawHUD"; Description: "FlawHUD"; ExtraDiskSpaceRequired: 2770000
Name: "HUDs/ahud"; Description: "ahud"; ExtraDiskSpaceRequired: 521510
Name: "HUDs/ToonHUD"; Description: "ToonHUD"; ExtraDiskSpaceRequired: 915110
Name: "HUDs/budhud"; Description: "budhud"; ExtraDiskSpaceRequired: 13140000

;Animation Overhauls
Name: "AnimOver"; Description: "Animation Overhauls"
Name: "AnimOver/Pyro"; Description: "Pyro FP Reanimated V.1"; ExtraDiskSpaceRequired: 657489; Types: viewmodel_far viewmodel_close
Name: "AnimOver/Sniper"; Description: "Sniper FP Animation Overhaul"; ExtraDiskSpaceRequired: 1200000; Types: viewmodel_far viewmodel_close
Name: "AnimOver/Soviet_Stand_off"; Description: "Taunt Replacement: Soveiet Stand-Off"; ExtraDiskSpaceRequired: 1448779
; Far Viewmodels
Name: "AnimOver/Far"; Description: "Far Viewmodels (70+ FOV)"; Types: viewmodel_far
Name: "AnimOver/Far/ScoutFar"; Description: "Scout FP Animation Overhaul"; ExtraDiskSpaceRequired: 1047691; Types: viewmodel_far
Name: "AnimOver/Far/DemoFar"; Description: "Demo FP Animations Remade"; ExtraDiskSpaceRequired: 1450000; Types: viewmodel_far
Name: "AnimOver/Far/HeavyFar"; Description: "Heavy First Person Animation Overhaul"; ExtraDiskSpaceRequired: 1773332; Types: viewmodel_far
Name: "AnimOver/Far/EngineerFar"; Description: "Paysus' Engineer First Person Animation Overhaul"; ExtraDiskSpaceRequired: 2055449; Types: viewmodel_far
;Close Viewmodels
Name: "AnimOver/Close"; Description: "Close Viewmodels (54 FOV)"; Types: viewmodel_close
Name: "AnimOver/Close/ScoutClose"; Description: "Scout FP Animation Overhaul"; ExtraDiskSpaceRequired: 1047691; Types: viewmodel_close
Name: "AnimOver/Close/DemoClose"; Description: "Demo FP Animations Remade"; ExtraDiskSpaceRequired: 1450000; Types: viewmodel_close
Name: "AnimOver/Close/HeavyClose"; Description: "Heavy First Person Animation Overhaul"; ExtraDiskSpaceRequired: 1773332; Types: viewmodel_close
Name: "AnimOver/Close/EngineerClose"; Description: "Paysus' Engineer First Person Animation Overhaul"; ExtraDiskSpaceRequired: 2055449; Types: viewmodel_close

;Model Replacers
Name: "ModelReplace"; Description: "Model Replacers"
Name: "ModelReplace/ScoutAlien"; Description: "Scout Alien hands viewmodel"; ExtraDiskSpaceRequired: 3563169
Name: "ModelReplace/scout_lucario"; Description: "Scout Lucario"; ExtraDiskSpaceRequired: 1041989
Name: "ModelReplace/TinyDeskEngie"; Description: "Tiny Desk Engineer Over Intel"; ExtraDiskSpaceRequired: 1251824
Name: "ModelReplace/RoboHeavy"; Description: "Robo-Heavy Sentry"; ExtraDiskSpaceRequired: 14152674

;Misc
Name: "MiscMods"; Description: "Miscellaneous Mods"
Name: "MiscMods/ValveNew"; Description: "Valve ""Open your mind"" intro"; ExtraDiskSpaceRequired: 11298648
Name: "MiscMods/SoundMods"; Description: "Sound Mods";
Name: "MiscMods/SoundMods/SpyWard"; Description: "Squidward As The Spy (SpyWard)"; ExtraDiskSpaceRequired: 23063690 
Name: "MiscMods/SoundMods/SpongeBob_Overtime"; Description: "Spongebob OVERTIME!!"; ExtraDiskSpaceRequired: 22443
Name: "MiscMods/SoundMods/Snatcher"; Description: "Snatcher the Announcer"; ExtraDiskSpaceRequired: 34669115
Name: "MiscMods/SoundMods/PeaceandTranquilQueue"; Description: "Peace and Tranquility | Queue music"; ExtraDiskSpaceRequired: 30598665
Name: "MiscMods/LargeMods"; Description: "Large Mods"
Name: "MiscMods/LargeMods/TF2Classic"; Description: "Team Fortress 2 Classic"; ExtraDiskSpaceRequired: 3700000000

[Run]
;Backup Current MyCustomStuff
Filename: "{cmd}"; Parameters: "/c xcopy /E /I /Y ""{app}\my_custom_stuff"" ""{app}\my_custom_stuff_backup"""; Flags: runhidden; StatusMsg: "Backing up my_custom_stuff folder..."; Components: MiscMods/SoundMods MiscMods/SoundMods/Snatcher MiscMods/SoundMods/SpyWard MiscMods/SoundMods/PeaceandTranquilQueue
;Huds
Filename: "{tmp}\7za.exe"; Parameters: "x ""{tmp}\TFPlus.zip"" -o""{app}\"" * -r -aoa"; Flags: runhidden; Description: "TF2 Hud Plus"; StatusMsg: "Installing TF2 Hud Plus"; Components: HUDs/TFPlus
Filename: "{tmp}\7za.exe"; Parameters: "x ""{tmp}\rayshud.zip"" -o""{app}\"" * -r -aoa"; Flags: runhidden; Description: "rayshud"; StatusMsg: "Installing rayshud"; Components: HUDs/rayshud
Filename: "{tmp}\7za.exe"; Parameters: "x ""{tmp}\ahud.zip"" -o""{app}\"" * -r -aoa"; Flags: runhidden; Description: "FlawHUD"; StatusMsg: "Installing FlawHUD"; Components: HUDs/ahud
Filename: "{tmp}\7za.exe"; Parameters: "x ""{tmp}\FlawHUD.zip"" -o""{app}\"" * -r -aoa"; Flags: runhidden; Description: "FlawHUD"; StatusMsg: "Installing FlawHUD"; Components: HUDs/flawhud
Filename: "{tmp}\7za.exe"; Parameters: "x ""{tmp}\toonhud.zip"" -o""{app}\"" * -r -aoa"; Flags: runhidden; Description: "ToonHUD"; StatusMsg: "Installing ToonHUD"; Components: HUDs/toonhud
Filename: "{tmp}\7za.exe"; Parameters: "x ""{tmp}\budhud.zip"" -o""{app}\"" * -r -aoa"; Flags: runhidden; Description: "budhud"; StatusMsg: "Installing budhud"; Components: HUDs/budhud
;Misc
Filename: "{tmp}\7za.exe"; Parameters: "x ""{tmp}\TinyDeskEngie.zip"" -o""{tmp}\tiny"" * -r -aoa"; Flags: runhidden; Description: "TinyDeskEngie"; StatusMsg: "Extracting Tiny Desk Engineer Over Intel"; Components: ModelReplace/TinyDeskEngie
Filename: "{tmp}\7za.exe"; Parameters: "x ""{tmp}\RoboHeavy.zip"" -o""{app}\"" * -r -aoa"; Flags: runhidden; Description: "RoboHeavy"; StatusMsg: "Installing Robo-Heavy Sentry"; Components: ModelReplace/RoboHeavy
Filename: "{cmd}"; Parameters: "/c copy ""{tmp}\tiny\Tiny Desk Engineers.vpk"" ""{app}"""; Flags: runhidden; StatusMsg: "Installing Tiny Desk Engineer Over Intel"; Components: ModelReplace/TinyDeskEngie
Filename: "{tmp}\7za.exe"; Parameters: "x ""{tmp}\valveNew.zip"" -o""{tmp}\valve"" * -r -aoa"; Flags: runhidden; Description: "ValveNew"; StatusMsg: "Extracting Valve ""Open your mind"" intro"; Components: MiscMods/ValveNew
Filename: "{cmd}"; Parameters: "/c copy ""{tmp}\valve\tf\media\valve.bik"" ""{#MediaPath}"""; Flags: runhidden; StatusMsg: "Installing Valve ""Open your mind"" intro"; Components: MiscMods/ValveNew
;Animations
Filename: "{tmp}\7za.exe"; Parameters: "x ""{tmp}\soviet_standoff.zip"" -o""{tmp}\scout"" * -r -aoa"; Flags: runhidden; Description: "heavy"; StatusMsg: "Extracting Taunt Replacement: Soviet Stand-Off"; Components: AnimOver/Soviet_Stand_off
Filename: "{cmd}"; Parameters: "/c copy ""{tmp}\Heavy's Bizarre Adventure Taunt mod\heavyjojopost.vpk"" ""{app}"""; Flags: runhidden; Description: "heavy"; StatusMsg: "Installing Taunt Replacement: Soviet Stand-Off"; Components: AnimOver/Soviet_Stand_off
Filename: "{tmp}\7za.exe"; Parameters: "x ""{tmp}\scout.zip"" -o""{tmp}\scout"" * -r -aoa"; Flags: runhidden; Description: "scout"; StatusMsg: "Extracting Scout FP Animation Overhaul"; Components: AnimOver/Close/ScoutClose AnimOver/Far/ScoutFar
Filename: "{tmp}\7za.exe"; Parameters: "x ""{tmp}\pyro.zip"" -o""{tmp}\pyro"" * -r -aoa"; Flags: runhidden; Description: "scout"; StatusMsg: "Extracting Pyro FP Reanimated V.1"; Components: AnimOver/Pyro
Filename: "{tmp}\7za.exe"; Parameters: "x ""{tmp}\demoman.zip"" -o""{tmp}\demo"" * -r -aoa"; Flags: runhidden; Description: "demoman"; StatusMsg: "Extracting Demo FP Animations Remade"; Components: AnimOver/Far/DemoFar AnimOver/Close/DemoClose
Filename: "{tmp}\7za.exe"; Parameters: "x ""{tmp}\heavy.zip"" -o""{tmp}\heavy"" * -r -aoa"; Flags: runhidden; Description: "heavy"; StatusMsg: "Extracting Heavy First Person Animation Overhaul"; Components: AnimOver/Close/HeavyClose AnimOver/Far/HeavyFar
Filename: "{tmp}\7za.exe"; Parameters: "x ""{tmp}\engineer.zip"" -o""{tmp}\engineer"" * -r -aoa"; Flags: runhidden; Description: "engineer"; StatusMsg: "Extracting Paysus' Engineer First Person Animation Overhaul"; Components: AnimOver/Close/EngineerClose AnimOver/Far/EngineerFar
Filename: "{cmd}"; Parameters: "/c copy ""{tmp}\pyro\Kyle's Pyro FPS Overhaul V.1\Kyle Pyro FP Overhaul V.1.vpk"" ""{app}"""; Flags: runhidden; StatusMsg: "Installing Kyle's Pyro FPS Overhaul V.1"; Components: AnimOver/Pyro
Filename: "{tmp}\7za.exe"; Parameters: "x ""{tmp}\sniper.zip"" -o""{app}\"" * -r -aoa"; Flags: runhidden; Description: "sniper"; StatusMsg: "Installing Sniper FP Animation Overhaul"; Components: AnimOver/Sniper
;Far Viewmodels
Filename: "{cmd}"; Parameters: "/c copy ""{tmp}\scout\ScoutOverhaulV3\Scout FP Overhaul - 70+ FOV.vpk"" ""{app}"""; Flags: runhidden; StatusMsg: "Installing Scout FP Animation Overhaul (Far)"; Components: AnimOver/Far/scoutfar
Filename: "{cmd}"; Parameters: "/c copy ""{tmp}\demo\Demo FP Anims - Far.vpk"" ""{app}"""; Flags: runhidden; StatusMsg: "Installing Demo FP Animations Remade (Far)"; Components: AnimOver/Far/demofar
Filename: "{cmd}"; Parameters: "/c copy ""{tmp}\heavy\70+ FOV\Heavy FP Animation Overhaul V3.1.vpk"" ""{app}"""; Flags: runhidden; StatusMsg: "Installing Heavy First Person Animation Overhaul (Far)"; Components: AnimOver/Far/heavyfar
Filename: "{cmd}"; Parameters: "/c copy ""{tmp}\heavy\70+ FOV\Heavy FP Animation Overhaul V3.1 - Alt Minigun Animations.vpk"" ""{app}"""; Flags: runhidden; StatusMsg: "Installing Heavy First Person Animation Overhaul (Far)"; Components: AnimOver/Far/heavyfar
Filename: "{cmd}"; Parameters: "/c copy ""{tmp}\heavy\70+ FOV\Heavy FP Animation Overhaul V3.1 - Alt Fist Animations.vpk"" ""{app}"""; Flags: runhidden; StatusMsg: "Installing Heavy First Person Animation Overhaul (Far)"; Components: AnimOver/Far/heavyfar
Filename: "{cmd}"; Parameters: "/c copy ""{tmp}\engineer\70+ FOV\Engineer FP Overhaul.vpk"" ""{app}"""; Flags: runhidden; StatusMsg: "Installing Paysus' Engineer First Person Animation Overhaul (Far)"; Components: AnimOver/Far/engineerfar
;Close viewmodels
Filename: "{cmd}"; Parameters: "/c copy ""{tmp}\scout\ScoutOverhaulV3\Scout FP Overhaul - 54 FOV.vpk"" ""{app}"""; Flags: runhidden; StatusMsg: "Installing Scout FP Animation Overhaul (Close)"; Components: AnimOver/Close/scoutclose
Filename: "{cmd}"; Parameters: "/c copy ""{tmp}\demo\Demo FP Anims - Close.vpk"" ""{app}"""; Flags: runhidden; StatusMsg: "Installing Demo FP Animations Remade (Close)"; Components: AnimOver/Close/democlose
Filename: "{cmd}"; Parameters: "/c copy ""{tmp}\heavy\54 FOV\Heavy FP Animation Overhaul V3.1.vpk"" ""{app}"""; Flags: runhidden; StatusMsg: "Installing Heavy First Person Animation Overhaul (Close)"; Components: AnimOver/Close/heavyclose
Filename: "{cmd}"; Parameters: "/c copy ""{tmp}\heavy\54 FOV\Heavy FP Animation Overhaul V3.1 - Alt Minigun Animations.vpk"" ""{app}"""; Flags: runhidden; StatusMsg: "Installing Heavy First Person Animation Overhaul (Close)"; Components: AnimOver/Close/heavyclose
Filename: "{cmd}"; Parameters: "/c copy ""{tmp}\heavy\54 FOV\Heavy FP Animation Overhaul V3.1 - Alt Fist Animations.vpk"" ""{app}"""; Flags: runhidden; StatusMsg: "Installing Heavy First Person Animation Overhaul (Close)"; Components: AnimOver/Close/heavyclose
Filename: "{cmd}"; Parameters: "/c copy ""{tmp}\engineer\54 FOV\Engineer FP Overhaul.vpk"" ""{app}"""; Flags: runhidden; StatusMsg: "Installing Paysus' Engineer First Person Animation Overhaul (Close)"; Components: AnimOver/Close/engineerclose
;Model Replacer
;Lucario Scout
Filename: "{tmp}\7za.exe"; Parameters: "x ""{tmp}\scout_alien.zip"" -o""{app}"" * -r -aoa"; Flags: runhidden; Description: "scoutalien"; StatusMsg: "Installing Scout Alien hands viewmodel"; Components: ModelReplace/scoutalien
Filename: "{tmp}\7za.exe"; Parameters: "x ""{tmp}\scoutLucario.zip"" -o""{tmp}\scout"" * -r -aoa"; Flags: runhidden; Description: "ScoutLucario"; StatusMsg: "Extracting Scout Lucario"; Components: ModelReplace/scout_lucario
Filename: "{cmd}"; Parameters: "/c copy ""{tmp}\scout\LucarioScout.vpk"" ""{app}"""; Flags: runhidden; StatusMsg: "Installing Scout Lucario"; Components: ModelReplace/scout_lucario
;Sound Changes
;Spyward
Filename: "{tmp}\7za.exe"; Parameters: "x ""{tmp}\spyward.zip"" -o""{tmp}\spy"" * -r -aoa"; Flags: runhidden; Description: "Spyward"; StatusMsg: "Extracting Squidward As The Spy (SpyWard)"; Components: MiscMods/SoundMods/spyward
Filename: "{cmd}"; Parameters: "/c copy ""{tmp}\spy\SpyWard V4.vpk"" ""{app}"""; Flags: runhidden; StatusMsg: "Installing Squidward As The Spy (SpyWard)"; Components: MiscMods/SoundMods/spyward
Filename: "{cmd}"; Parameters: "/c xcopy /E /I /Y ""{tmp}\spy\SpyWard V4\sound"" ""{app}\my_custom_stuff\sound"""; Flags: runhidden; StatusMsg: "Installing Squidward As The Spy (SpyWard)"; Components: MiscMods/SoundMods/spyward
;Spongebob Overtime
Filename: "{tmp}\7za.exe"; Parameters: "x ""{tmp}\Spongebob_Overtime.zip"" -o""{app}"" * -r -aoa"; Flags: runhidden; Description: "spongebob"; StatusMsg: "Installing Spongebob OVERTIME!!"; Components: MiscMods/SoundMods/Spongebob_Overtime
;Snatcher
Filename: "{tmp}\7za.exe"; Parameters: "x ""{tmp}\snatcher.zip"" -o""{tmp}\"" * -r -aoa"; Flags: runhidden; Description: "Snatcher"; StatusMsg: "Extracting Snatcher the Announcer"; Components: MiscMods/SoundMods/snatcher
Filename: "{cmd}"; Parameters: "/c xcopy /E /I /Y ""{tmp}\SnatcherAnnouncer\sound"" ""{app}\my_custom_stuff\sound"""; Flags: runhidden; StatusMsg: "Installing Snatcher the Announcer"; Components: MiscMods/SoundMods/snatcher
;Peace And Tranquility | Queue Music
Filename: "{tmp}\7za.exe"; Parameters: "x ""{tmp}\PaTQMusic.zip"" -o""{tmp}\PaTQMusic"" * -r -aoa"; Flags: runhidden; StatusMsg: "Extracting Peace and Tranquility | Queue music"; Components: MiscMods/SoundMods/PeaceandTranquilQueue
Filename: "{cmd}"; Parameters: "/c xcopy /E /I /Y ""{tmp}\PaTQMusic\sound"" ""{app}\my_custom_stuff\sound"""; Flags: runhidden; StatusMsg: "Installing Peace and Tranquility | Queue music"; Components: MiscMods/SoundMods/PeaceandTranquilQueue

;tf2classic
Filename: "{tmp}\TF2-Classic_Installer.exe"; Parameters: "/SILENT /TYPE=""full"""; Flags: runascurrentuser waituntilterminated; Description: "Waiting for TF2 Classic Installer..."; Components: MiscMods/LargeMods/TF2Classic

[UninstallDelete]
Type: filesandordirs; Name: "{app}\tf2hudplus-master"; Components: HUDs/tfplus
Type: filesandordirs; Name: "{app}\rayshud-master"; Components: HUDs/rayshud
Type: filesandordirs; Name: "{app}\flawhud-master"; Components: HUDs/flawhud
Type: filesandordirs; Name: "{app}\ahud-master"; Components: HUDs/ahud
Type: filesandordirs; Name: "{app}\budhud-master"; Components: HUDs/budhud
Type: filesandordirs; Name: "{app}\toonhud"; Components: HUDs/toonhud
Type: filesandordirs; Name: "{app}\Tiny Desk Engineers.vpk"; Components: ModelReplace/tinydeskengie
Type: filesandordirs; Name: "{app}\Robot Heavy Sentry"; Components: ModelReplace/roboheavy
Type: filesandordirs; Name: "{app}\Robot Heavy Sentry.vpk"; Components: ModelReplace/roboheavy
Type: filesandordirs; Name: "{app}\LucarioScout.vpk"; Components: ModelReplace/scout_lucario
Type: filesandordirs; Name: "{app}\scout_alien_hands_000.vpk"; Components: ModelReplace/scoutalien
Type: filesandordirs; Name: "{app}\scout_alien_hands_dir.vpk"; Components: ModelReplace/scoutalien
Type: filesandordirs; Name: "{app}\readme.txt"; Components: AnimOver/sniper
Type: filesandordirs; Name: "{app}\Sniper FP Anim Overhaul.vpk"; Components: AnimOver/sniper
Type: filesandordirs; Name: "{app}\Demo FP Anims - Far.vpk"; Components: AnimOver/Far/demofar
Type: filesandordirs; Name: "{app}\Demo FP Anims - Close.vpk"; Components: AnimOver/Close/democlose
Type: filesandordirs; Name: "{app}\Scout FP Overhaul - 70+ FOV.vpk"; Components: AnimOver/Far/scoutfar
Type: filesandordirs; Name: "{app}\Scout FP Overhaul - 54 FOV.vpk"; Components: AnimOver/Close/scoutclose
Type: filesandordirs; Name: "{app}\Engineer FP Overhaul.vpk"; Components: AnimOver/Far/engineerfar AnimOver/Close/engineerclose
Type: filesandordirs; Name: "{app}\Heavy FP Animation Overhaul V3.1.vpk"; Components: AnimOver/Far/heavyfar AnimOver/Close/heavyclose
Type: filesandordirs; Name: "{app}\Heavy FP Animation Overhaul V3.1 - Alt Minigun Animations.vpk"; Components: AnimOver/Far/heavyfar AnimOver/Close/heavyclose
Type: filesandordirs; Name: "{app}\Heavy FP Animation Overhaul V3.1 - Alt Fist Animations.vpk"; Components: AnimOver/Far/heavyfar AnimOver/Close/heavyclose
Type: filesandordirs; Name: "{app}\Kyle Pyro FP Overhaul V.1.vpk"; Components: AnimOver/pyro
Type: filesandordirs; Name: "{app}\SpyWard V4.vpk"; Components: MiscMods/SoundMods/SpyWard
Type: filesandordirs; Name: "{#MediaPath}\valve.bik"; Components: MiscMods/ValveNew
Type: filesandordirs; Name: "{app}\heavyjojopose.vpk"; Components: AnimOver/Soviet_Stand_off
Type: filesandordirs; Name: "{app}\SpongeBob OVERTIME!!.vpk"; Components: MiscMods/SoundMods/SpongeBob_Overtime


Type: filesandordirs; Name: "{app}\my_custom_stuff"; Components: MiscMods/SoundMods/Snatcher MiscMods/SoundMods/SpyWard

[Messages]
BeveledLabel=Team Fortress 2 Mod Installer
WelcomeLabel1=Thank you for downloading the [name]!
WelcomeLabel2=[name] allows you to install TF2 Mods easily! All you need to do is select what mods you want%n%nPlease make sure TF2 is closed, as it may cause issues if you try to install mods while it is running.
ClickNext=Click Next to continue, or Cancel to exit.
SetupWindowTitle=%1
UninstallAppFullTitle=Uninstall TF2 Mods
UninstallAppTitle=Uninstall TF2 Mods
UninstalledAll=Uninstalled all TF2 Mods from TF2 Mod Installer successfully
UninstallStatusLabel=Please wait while all TF2 Mods installed using TF2 Mod Installer are being removed.
ConfirmUninstall=Are you sure you want to uninstall all TF2 Mods that were installed using TF2 Mod Installer? This will not affect any of your mods that you didn't install using this tool.
SelectComponentsDesc=What mods would you like?
SelectComponentsLabel2=Select the mods you would like to install. Remember, do not install both Far and Close viewmodels at the same time. Click Next when you are ready!
WizardSelectComponents=Select Mods
WizardUninstalling=Removing Mods...
WizardInstalling=Innstalling Mods...
InstallingLabel=Please wait will your selected mods are being installed.
SelectDirDesc=Where do you want to install your mods?
SelectDirLabel3=I will put the mods in the following folder.
SelectDirBrowseLabel=Once you have selected the folder you want to install your mods to, click Next. (Default Recommended)
ReadyLabel1=I have gathered all the info I needed! Ready to install your mods! :D
StatusExtractFiles=Copying files...
StatusUninstalling=Removing TF2 Mods installed using TF2 Mod Installer...
ShutdownBlockReasonUninstallingApp=Removing TF2 Mods installed using TF2 Mod Installer...
FinishedLabelNoIcons=The TF2 Mods you have selected have been installed!
FinishedLabel=The TF2 Mods you have selected have been installed!
FinishedHeadingLabel=Done installing Mods!

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
