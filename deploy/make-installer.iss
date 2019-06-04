; =====================================================================
; == demo\make-installer-outlook.iss
; == Part of VstoAddinInstaller
; == (https://github.com/bovender/VstoAddinInstaller)
; == (c) 2016-2018 Daniel Kraus <bovender@bovender.de>
; == Published under the Apache License 2.0
; == See http://www.apache.org/licenses
; =====================================================================
;
; This is the configuration file for the demo installer.
; To try out this script, you must first build the VSTO project in
; Visual Studio with Debug configuration.

#define VERSIONFILE "VERSION.TXT"

#define TARGET_HOST "outlook"
#define APP_GUID "{{44803b20-568c-4cf2-8c03-7829a0feb077}"
#define ADDIN_NAME "DelaySend for Outlook"
#define ADDIN_SHORT_NAME "DelaySendOutlook"
#define COMPANY "Stewart Cossey"
#define HOMEPAGE "https://github.com/Cossey/DelaySend"
#define DESCRIPTION "DelaySend Add-in for Microsoft Outlook."
#define PUB_YEARS "2019"

#define SOURCEDIR "..\DelaySend\bin\Debug\"
#define VSTOFILE "DelaySend.vsto"
#define OUTPUTDIR "releases\"

; #define LOGFILE "INST-LOG.TXT"

#define SETUPFILESDIR "setup-files\"

; If the VstoAddinInstaller files are in a different subdirectory
; than 'VstoAddinInstaller', change the path below.
#include ".\VstoAddinInstaller\vsto-installer.iss"

; vim: ts=2 sts=2 sw=2 et