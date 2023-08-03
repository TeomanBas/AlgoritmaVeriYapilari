using System.Collections;
using DataStructures;
internal class Program
{
    private static void Main(string[] args)
    {
        // char dizisi tanımlama // fixed size
        var arrChar = new char[2] { 'a', 'b' };

        // array dizisi tanımlama
        var arrInt = Array.CreateInstance(typeof(int), 4);
        arrInt.SetValue(10, 0);// arrInt[0] = 10;
        arrInt.GetValue(0); // 10 değeri döner

        // ArrayList dizisi (dinamik dizi) - tip güvenliği kaybedilir. boxing ve unboxing vardır ve obje döndürür.
        var arrObj = new ArrayList();
        arrObj.Add(10);
        arrObj.Add("b");

        var c = ((int)arrObj[0] + 20);

        // List<T> generic ifadelerden olan List<T> tip güvenliğini sağlar kutulama işlemi yoktur.
        var arrListInt = new List<int>();
        arrListInt.Add(10);
        arrListInt.Add('b');// burada b nin karşılığı olan 98 değeri diziye eklenir.chardan int dönüşüm mümkündür.
        // aşağıdaki kod hata verecektir.
        //arrListInt.Add(("b");
        // aşağıda cast işlemi yapmadan dizi elemenını int olarak alabildik.
        var d = (arrListInt[0] + 20);

    }
}