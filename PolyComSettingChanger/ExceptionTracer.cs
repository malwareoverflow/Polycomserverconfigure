using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.MessageBox;
namespace PolyComSettingChanger
{
    class ExceptionTracer
    {
    public    static void Log(
    string message,
    [CallerMemberName] string memberName = null,
    [CallerFilePath] string filePath = null,
    [CallerLineNumber] int lineNumber = 0)
        {
            Show($"Datetime={DateTime.UtcNow}\nMember={memberName}\nFilepath={filePath}\nLinenumber={lineNumber}\nMessage={message}");
        }
    }
}
