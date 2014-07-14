; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "GizmoApp"
#define MyAppVersion "1.5"
#define MyAppPublisher "My Company, Inc."
#define MyAppURL "http://www.example.com/"
#define MyAppExeName "GizmoApp.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{9E85E7E8-988A-4319-881F-83257DE1EC58}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName=C:\GizmoApp\{#MyAppName}
DisableDirPage=yes
DefaultGroupName={#MyAppName}
LicenseFile=C:\Users\Danijel\Desktop\Licensa.txt
OutputDir=C:\Users\Danijel\Desktop
OutputBaseFilename=GizmoSetup
SetupIconFile=C:\Users\Danijel\Desktop\Projekt\GizmoApp\gizmo_icon_transparent.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\Danijel\Desktop\Projekt\GizmoApp\GizmoApp\bin\Debug\GizmoApp.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Danijel\Desktop\Projekt\GizmoDB\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\Danijel\Documents\GitHub\RepositoryTeam30\Projektna dokumentacija\Help\Documentation.chm"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Danijel\Documents\GitHub\RepositoryTeam30\Projektna dokumentacija\Gizmo Net_Korisni�ka dokumentacija.pdf"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent
