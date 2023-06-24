# 1. Algoritma ve Veri Yapıları
Bu repository içerisinde Algoritma ve Veri Yapıları için aldığım notlar, uygulamalarım ve örnekler yer alıyor

## 1.1 Veri Yapıları (Data Structures)
Veri yapısı,veriye erişim verinin depolanmasını ve verinin organizasyonunu temsil eder.

Bir veri yapısı, veri değerleri, veriler arasındaki ilişkiler ve verilere uygulanabilecek işlevler veya işlemlerin bir koleksiyonudur.

Genellikle verimli veri yapıları,verimli algoritmaları oluşturmanın yoludur.


- linear
    - array
        - single dimension array
        - multi dimension array
    - list
        - array list
        - generic list
        - sorted list
        - linked list
    - stack
    - queue
- non-linear
    - graf
        - tree
            - binary tree
                - binary search tree
                    - self balancing tree
                        - AVL tree
                        - Red-black tree
            - heap
                - binary heap
                - binominal heap
                - fibonacci heap
## 1.2 Veri Tipleri

- data types
    - value types
        - struct
        - enum
    - reference types
        - class
        - interface
        - delegate

<code>value_type: struct_type | enum_type;</code><br>
<code>enum_type: type_name ;</code><br>
<code>struct_type: type_name | simple_type | nullable_type;</code><br>
<code>simple_type: numeric_type | 'bool';</code><br>
<code>numeric_type: integral_type | floating_point_type | 'decimal';</code><br>
<code>nullable_type: non_nullable_value_type '?';</code><br>
<code>non_nullable_value_type: type;</code><br>
<code>enum_type:type_name;</code><br>
<code>floating_point_type: 'float' | 'double';</code><br>
<code>integral_type: 'sbyte' | 'byte' | 'short' | 'ushort' | 'int' | 'uint' | 'long' | 'ulong' | 'char';</code><br>


### Yerleşik Veri Türleri

- built-in data type (value)
    - short
    - int 
    - double
    - char
    - decimal
- built-in data type (reference)
    - object
    - string
    - dynamic

### Kullanıcı Tanımlı Veri Türleri

- Custom/user defined data type(value)
    - struct
- Custom/user defined data type (reference)
    - class

#### Struct
- Farklı veri türlerini tek bir yapı altında toplamaya ihtiyaç duyulduğunda struct kullanılabilir.
- Temel amaç verinin bütününü temsil edecek alt veri türlerini bir yapı altında toplamaktır.
- Verinin organize edilmesi için kullanılan en eski programlama bileşenlerinden biridir.
- Küçük ölçekli verileri organize etmek gerektiğinde class yapılarının yerine struct yapısı kullanılabilir.
- Struct tanımlaması class tanımlama yapısına benzemektedir. 
- Struct yapısı değer(value) tiplidir;sınıflar gibi referans tipli değildir
- Struct kullanımı tamamlandıktan sonra bellekten hızlıca kaldırılabilir.
- Bu yapıların bellekten kaldırılmasını beklemek üzere Garbage Collection'ın beklenmesine gerek yoktur.
- Sınıf yapısına kıyasla performansı daha iyidir.
- Kalıtımı desteklemezler
- Struct yapısının da System.ValueType'dan türetilir.
- Struct yapısı kalıtımın uygulanmasını desteklemek ancak interface inheritance destekler.
- Struct yapısı bir metoda parametre olarak uygulanacak ise dikkat edilmelidir
- Struct yapısı her zaman stack (yığında) tutulmaz.Bazı durumlarda heap bölgesinde de tutulabilirler.
- C# 7.2 ile birlikte construct referans türler heap bölümünde ve value türleri tipik olarak stack bölümünde tutulurlar.
- Value tipleri sadece stack bölümünde tutulurlar.

#### Class
- Nesne yönelimli programlamanın temel öğesidir.
- İçerisinde field,property,method,operatör gibi pek çok farklı üye barındırır.
- Referans tipli bir veri türüdür.
- Sınıf ve arayüz kalıtımını destekler

## 1.3 Veri Organizasyonu
- Değişken
    - Hafızada bir yer ayırmak gerekli durumlarda ayrılan yere değer atamak değeri değiştirmek ve okumak için kullaılan programlama bileşeni değişken olarak adlandırılır.
    - Bir başka ifadeyle değişken, bir değeri tutan depolama konumudur.
    - Değişken, üç temel boyutu ile düşünülmelidir.
    - Sabitler program boyunca değeri değişmeyen özel bir değişken türü olarak düşünülebilir.

**x in alabileceği değerler**
| -128 |. . .|X|. . .| 127 |
|---|---|---|---|---|

**1 byte = 8 bit** <br>
**sbyte tipinde tanımlanan bir x değikeni olsun.**
<code>sbyte x = 127; </code>

|0|1|1|1|1|1|1|1|
|---|---|---|---|---|---|---|---|
|signed/unsigned bit 2<sup>7</sup> |2<sup>6</sup>|2<sup>5</sup>|2<sup>4</sup>|2<sup>3</sup>|2<sup>2</sup>|2<sup>1</sup>|2<sup>0</sup>|

burada eğer 1 ise o bit altındaki değer alınır değilse alınmaz
<code>0</sup>+2<sup>6</sup>+2<sup>5</sup>+2<sup>4</sup>+2<sup>3</sup>+2<sup>2</sup>+2<sup>1</sup>+2<sup>0</sup>=255</code> <br>
eğer en soldaki bit 0 ise sayı pozitif 1 ise negatif anlamına gelir hesaplamaya dahil edilmez işaret bitidir.işaretli veri tipleri sbyte,double,int gibi veri tipleri negatif yada pozitif değerler tutabilen veri tipleridir.

istisna bir durumda eğer işaret biti 1 olsaydı aşağıdaki gibi ... <br>
|1|0|0|0|0|0|0|0|
|---|---|---|---|---|---|---|---|
|signed bit 2<sup>7</sup>|2<sup>6</sup>|2<sup>5</sup>|2<sup>4</sup>|2<sup>3</sup>|2<sup>2</sup>|2<sup>1</sup>|2<sup>0</sup>|

<code>2<sup>7</sup>+0+0+0+0+0+0+0=-128</code>

eğer **X** değişkeni <code>byte</code> olarak tanımlanmış olsaydı 0 ile 255 arasında değer alabilirdi yani işaretsiz bir veri türü olduğu için bellekteki organizasyonuda farklılık gösterecektir.255 değerini elde etmek için sadece tüm bitler 1 olacaktır.

|1|1|1|1|1|1|1|1|
|---|---|---|---|---|---|---|---|
|signed bit 2<sup>7</sup>|2<sup>6</sup>|2<sup>5</sup>|2<sup>4</sup>|2<sup>3</sup>|2<sup>2</sup>|2<sup>1</sup>|2<sup>0</sup>|

<code>2<sup>7</sup>+</sup>+2<sup>6</sup>+2<sup>5</sup>+2<sup>4</sup>+2<sup>3</sup>+2<sup>2</sup>+2<sup>1</sup>+2<sup>0</sup>=255</code> <br>


## 1.4 Soyut Veri Türü(Abstract Date Type)
- Yığın Ana İşlevler(last in first out)
    - yığınlar bağlı listeler veya diziler ile tasarlanabilir.
    - Push (T item) : yığına ekleme işlemi
    - Pop () : yığından eleman çıkartma
    - Peek () : yığından bir eleman çıkartılacaksa hangi elemean olduğu bilgisini verir ama yığından elemean çıkartmaz
- Kuyruk Ana İşlevler(first in first out)
    - dizi,dinamik dizi,bağlı liste,sabit boyutlu,çevrimsel dizi ile tasarlanabilir. 
    - EnQueue (T item) : kuytuğun sonuna eleman ekler
    - DeQueue () : liste başından elemean çıkartır.
    - Peek () : kuyruktan bir eleman çıkartılacaksa hangi elemean olduğu bilgisini verir ama yığından elemean çıkartmaz