# dGPUidle
Keeps dGPU running but idle. Prevents microstutter with nVidia optimus gpu switch in Windows 10.

Download rar  
Extract into single folder  
Run manually after windows log in

The app will briefly show a DX12 window then hide it into the background. To stop the application, run the .exe again and click "No" when prompted to continue running.

The code is based on sample code from https://github.com/discosultan/dx12-game-programming

Please feel free to improve on it.

UPDATE: dGPUidle fails on newer versions of Windows 10 (since Creators Update). Try [TrayPwrD3](https://github.com/jobeid/TrayPwrD3) instead.
