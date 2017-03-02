using System;
using SharpDX;
using SharpDX.Direct3D12;
using SharpDX.DXGI;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace DX12GameProgramming
{
    public class InitDirect3DApp : D3DApp
    {
        public InitDirect3DApp(IntPtr hInstance) : base(hInstance)
        {
            ClientWidth = 300;
            ClientHeight = 200;
            MainWindowCaption = "dGPU Idle";
        }
        protected override void Update(GameTimer gt)
        {
            //long f = CommandQueue.TimestampFrequency;
            //SetWindowText("Hi, freq=" + f); 
            //SetWindowText("Hi, Time=" + gt.DeltaTime);
            for (int i = 0; i < 20; i++)
            {
                Application.DoEvents();
                Thread.Sleep(100);
            }
            //string x = "Hi! " + gt.TotalTime;
            //Debug.WriteLine(x);
        }
        protected override void Draw(GameTimer gt)
        {
            // Reuse the memory associated with command recording.
            // We can only reset when the associated command lists have finished execution on the GPU.
            DirectCmdListAlloc.Reset();
        }
        
        protected override void DoWhilePaused(GameTimer gt)
        {
            //string x = "t=" + gt.TotalTime + " et=" + gt.DeltaTime;
            //Debug.WriteLine(x);
            // call only if needed: see if you can detect when amber light is red (dGPU off).
            if(gt.DeltaTime>3.5 || gt.DeltaTime < 0)
            {
                //Debug.WriteLine("Calling OnResize()");
                OnResize();
            }
            // wait 3 sec's:
            for (int i = 0; i < 10; i++)
            {
                Application.DoEvents();
                Thread.Sleep(300);
            }
        }
    }
}
