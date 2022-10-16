using System.Text;
using System.Security.Cryptography;
namespace Pintureria.Aplicacion.helpers;

public class HashHelper{
    public static string GetMD5(string str){
        MD5 md5 = MD5.Create();
        ASCIIEncoding encoding = new ASCIIEncoding();
        byte[]? stream = null;
        StringBuilder sb = new StringBuilder();
        stream = md5.ComputeHash(encoding.GetBytes(str));
        for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
        return sb.ToString();
    }
}