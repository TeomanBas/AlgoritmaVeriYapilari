using System.Collections;
using System.Threading.Channels;
using DataStructures;
using DataStructures.LinkedList.SinglyLinkedList;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
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

        */

        // --------------------------------------------------------------------------------------------------------------
        /*
        var arr = new DataStructures.Array.Array<int>();
        Console.WriteLine($"{arr.Count} / {arr.Capacity}");
        arr.Add( 1 );
        arr.Add( 2 );
        Console.WriteLine($"{arr.Count} / {arr.Capacity}");
        Console.WriteLine("-----");
        arr.Add( 3 );
        arr.Add( 4 );
        Console.WriteLine($"{arr.Count} / {arr.Capacity}");
        arr.Add(5);
        arr.Add(6);
        Console.WriteLine($"{arr.Count} / {arr.Capacity}");
        arr.Remove();
        Console.WriteLine($"{arr.Count} / {arr.Capacity}");
        Console.WriteLine("------");
        foreach ( var item in arr)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("------");
        // linq sorguları
        arr.Where(x => x % 2 == 00).ToList().ForEach(x => Console.WriteLine(x));

        /*
        var arr = new DataStructures.Array.Array<int>(11, 22, 3, 44, 66);
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("----------");
        var p1 = new DataStructures.Array.Array<int>(1, 2, 3, 4);
        var p2 = new int[] { 11, 22, 33, 44 };
        var p3 = new List<int>() { 5, 15, 20, 25 };
        var p4 = new ArrayList() { 122, 133, 1444, 1555 };
        // Generic tipler için IEnumerable GetEnumarable ı garanti ettiği için kullanabildik.
        var arrp1 = new DataStructures.Array.Array<int>(p1);
        foreach (var item in arrp1)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("----------");
        var arrp2 = new DataStructures.Array.Array<int>(p2);
        foreach (var item in arrp2)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("----------");

        var arrp3 = new DataStructures.Array.Array<int>(p3);
        foreach (var item in arrp3)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("----------");

        // ArrayList obje döndürür ve unboxing işlemi gerektirir bunu ArrayList için yapamıyoruz
       
        var arrp4 = new DataStructures.Array.Array<int>(p4);
        foreach (var item in arrp4)
        {
            Console.WriteLine(item);
        }
        

        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Dizi büyümesi ve küçülmesi");
        var arr = new DataStructures.Array.Array<int>(0);


        for (int i = 0; i < 129; i++)
        {
            arr.Add(i+1);
            Console.WriteLine($"{arr.Count} / {arr.Capacity}");

        }
        Console.WriteLine("---------");
        for (int i = arr.Count; i > 0; i--)
        {
            arr.Remove();
            Console.WriteLine($"{arr.Count} / {arr.Capacity}");

        }
        
        var arr = new DataStructures.Array.Array<int>(1, 2, 3, 4);
        // as deyimi ile cast ile işlemi yapar gibi obje döndüren bir nesneyi unboxing edilmesi gerekir.
        var cpyarr = arr.Clone() as DataStructures.Array.Array<int>;
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("-------");
        foreach (var item in cpyarr)
        {
            Console.WriteLine(item);
        }
        arr.Add(111);
        cpyarr.Add(333);
        Console.WriteLine("----ekleme işlemi sonrası---");
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("-------");
        foreach (var item in cpyarr)
        {
            Console.WriteLine(item);
        }
        
        // --------------------------------------------------------------------------------------------------------------
        // LINKED LIST (BAĞLI LİSTELER)
        // 
        var linkedlist = new SinglyLinkedList<int>();
        linkedlist.AddFirst(1);
        linkedlist.AddFirst(2);
        linkedlist.AddFirst(3);
        // 3 2 1

        linkedlist.AddLast(4);
        // 3 2 1 4

        linkedlist.AddAfter(linkedlist.Head.Next,32);
        // 3 2 32 1 4 

        linkedlist.AddBefore(linkedlist.Head.Next,33);
        // 3 33 2 32 1 4 

        var linkedlist1 = new SinglyLinkedList<int>();
        linkedlist1.AddFirst(11111);
        linkedlist1.AddFirst(22222);
        linkedlist1.AddFirst(33333);
        var linkedlist2 = new SinglyLinkedList<int>();
        linkedlist2.AddFirst(99999);
        linkedlist2.AddFirst(88888);
        linkedlist2.AddFirst(77777);

        linkedlist.AddBefore(linkedlist.Head.Next, linkedlist1.Head);
        linkedlist.AddAfter(linkedlist.Head.Next, linkedlist2.Head);
        // --------------------------------------------------------------------------------------------------------------
        //
        // IEnumarable<T> interface inin implementasyonu
        //
        var linkedlist = new SinglyLinkedList<int>();
        linkedlist.AddFirst(1);
        linkedlist.AddFirst(2);
        linkedlist.AddFirst(3);
        foreach ( var item in linkedlist)
        {
            Console.WriteLine(item);
        }
        
        // IEnumerable için yapılandırıcı metod tasarımı
        var arr = new char[] { 'a', 'b', 'c' };
        var arrList = new ArrayList(arr);
        var list = new List<char>(arr);
        var clinkedlist = new LinkedList<char>(arr);

        var linkedlist = new SinglyLinkedList<char>(arr);
        list.AddRange(new char[] { 'd', 'e', 'f' });
        foreach (var item in linkedlist)
        {
            Console.WriteLine(item);
        }
        

        //
        // Linq (Language Integrated Query) ile veri yapıları
        //
        // ramdom sayıların oluşturulması
        Console.WriteLine("random sayıların oluşturulup linkedlist nesnesi içerisine liste olarak alınması");
        var rnd = new Random();
        var initial = Enumerable.Range(1,10).OrderBy(i => rnd.Next()).ToList();
        var linkedlist = new SinglyLinkedList<int>(initial);
        
        foreach(var i in initial)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("linq sorgusu");
        // from anahtar sözcüğü link ifadeleri için bir sorgu yazılacağı anlamına gelir.
        var q = from item in linkedlist
                where item % 2 == 1
                select item;
        foreach (var i in q)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("koşul ifadesiyle linq sorgusu");
        linkedlist.Where(x => x > 5 )
            .ToList()
            .ForEach(x => Console.WriteLine(x + " "));
        */

        //
        // ilk elemanı silme
        // 
        var rnd = new Random();
        var initial = Enumerable.Range(1, 10).OrderBy(i => rnd.Next()).ToList();
        var linkedlist = new SinglyLinkedList<int>(initial);
        foreach (var i in linkedlist)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("ilk elemean siliniyor");
        linkedlist.RemoveFirst();
        foreach (var i in linkedlist)
        {
            Console.WriteLine(i);
        }

        // son elemanı silme
        Console.WriteLine("sondan iki eleman siliniyor");
        Console.WriteLine("{0} has been removed " , linkedlist.RemoveLast());
        Console.WriteLine("{0} has been removed ", linkedlist.RemoveLast());
        foreach (var i in linkedlist)
        {
            Console.WriteLine(i);
        }

        // aradan bir düğüm silmek
        Console.WriteLine("yeni düğüm oluşturuldu.");
        var linkedlist1 = new SinglyLinkedList<int>(new int[] { 1, 2, 3, 4, 5});
        foreach (var i in linkedlist1)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("aradan bir  eleman siliniyor");
        linkedlist1.Remove(4);
        foreach (var i in linkedlist1)
        {
            Console.WriteLine(i);
        }

        Console.ReadKey();
    }
}