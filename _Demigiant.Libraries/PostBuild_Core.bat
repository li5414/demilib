:: %1-2-3-4 = $(SolutionDir) $(TargetDir) $(TargetFileName) $(TargetName)

set BinDir=bin.Global\DemiLib\Core
set DestinationDir=%1..\..\%BinDir%
set BinDirNoMeta=bin.Global_no_meta\DemiLib\Core
set DestinationDirNoMeta=%1..\..\%BinDirNoMeta%
set BinDirUnityTests=DemiLib.UnityTests.Unity5\Assets\Demigiant\DemiLib\Core
set DestinationDirUnityTests=%1..\%BinDirUnityTests%

echo %DestinationDir%
echo %2

echo Deleting TMPs...
DEL %2\*.tmp

CD %2
echo Converting PDB to MDB and deleting PDB...
"c:\Program Files\pdb2mdb\pdb2mdb.exe" %3
DEL %4.pdb

echo Exporting Assembly to %DestinationDir%
echo Copying files to Destination...
echo f | xcopy "%1\bin\Core" %DestinationDir% /Y /I /E

echo Exporting Assembly to %DestinationDirNoMeta%
echo f | xcopy "%1\bin\Core" %DestinationDirNoMeta% /Y /I /E

echo Exporting Assembly to %DestinationDirUnityTests%
echo f | xcopy "%1\bin\Core" %DestinationDirUnityTests% /Y /I /E