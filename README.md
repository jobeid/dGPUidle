# dGPUidle
Keeps dGPU running but idle. Prevents microstutter with nVidia optimus gpu switch in Windows 10.

Download rar  
Extract into single folder  
Run manually after windows log in

The app will briefly show a DX12 window then hide it into the background. To stop the application, run the .exe again and click "No" when prompted to continue running.

The code is based on sample code from https://github.com/discosultan/dx12-game-programming

Please feel free to improve on it.

UPDATE: dGPU switch microstutters has been completely fixed in Windows 10 Creators Update build 15042 (Currently only available via windows insiders program). So if you have build 15042 or later you should not need dGPUidle.
