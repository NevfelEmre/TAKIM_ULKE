using System.Collections.Generic;
using System.IO;

namespace TAKIM_ULKE
{
    internal class Storage
    {
        internal static DoubleLinkedList<string> takimlar = new DoubleLinkedList<string>();
    }

    internal class DoubleLinkedList<T>
    {
        internal Node first = null, last = null;
        int size = 0;
        internal void Add(T tarih, T takim, T ulke)   //yeni düğümü traveler'ın hemen öncesine yerleştiriyoruz
        {
            Node node = new Node(tarih, takim, ulke);
            FindPosition(size, out Node traveler);
            if (traveler != first)
            {
                last.next = node;
                node.pre = last;
                last = node;
            }
            else
                first = last = node;
            size++;
        }
        internal void Remove(T takim)   //traveler'ın gösterdiği düğümü çıkarıyoruz
        {
            int pos = 0;
            Node traveler = first;
            for (; traveler != null; traveler = traveler.next)
            {
                if (traveler.takim.Equals(takim))
                    break;
                pos++;
            }
               
            if (pos is 0)   //baştakini çıkarır
            {
                if (first == last)
                    first = last = null;
                else
                {
                    first = traveler.next;
                    first.pre = null;
                }
            }
            else if (pos == size - 1)   //sondakini çıkarır
            {
                last = traveler.pre;
                last.next = null;
                traveler.pre = null;
            }
            else   //aradakini çıkarır
            {
                traveler.pre.next = traveler.next;
                traveler.next.pre = traveler.pre;
                traveler.pre = null;
                traveler.next = null;
            }
            size--;
        }
        internal bool hasUlke(T ulke)//Aranan ülke varsa true döndürür
        {
            bool isFound = false;
            Node traveler = first;
            for (; traveler != null; traveler = traveler.next)
            {
                if (traveler.ulke.Equals(ulke))
                {
                    isFound = true;
                    break;
                }
            }
            return isFound;
        }
        internal bool hasTakim(T takim)//Aranan takım varsa true döndürür
        {
            bool isFound = false;
            Node traveler = first;
            for (; traveler != null; traveler = traveler.next)
            {
                if (traveler.takim.Equals(takim))
                {
                    isFound = true;
                    break;
                }
            }
            return isFound;
        }
        internal Node FindNodeTakim(T takim)
        {
            bool isFound = false;
            Node traveler = first;
            for (; traveler != null; traveler = traveler.next)
                if (traveler.takim.Equals(takim))
                {
                    isFound = true;
                    break;
                }
            return isFound ? traveler : null;   //şart sağlanırsa düğümü, sağlanmazsa null geri döndürecek.
        }
        private void FindPosition(int pos, out Node traveler)
        {
            traveler = first;
            for (int i = 0; i < pos; i++)
                traveler = traveler.next;
        }
        internal IEnumerable<T> GetEnumeratorUlke()//ülkeyi sadece 1 defa geri gönderir
        {
            List<T> temporary = new List<T>();
            Node traveler = first;
            for (; traveler != null; traveler = traveler.next)
                if (!temporary.Contains(traveler.ulke))
                {
                    temporary.Add(traveler.ulke);
                    yield return traveler.ulke;
                }
        }
        internal IEnumerable<T> GetEnumeratorTakim(T ulke)//Aynı ülkeye mensup bütün takımları geri gönderir
        {
            for (Node traveler = first; traveler != null; traveler = traveler.next)
                if (traveler.ulke.Equals(ulke))
                    yield return traveler.takim;
        }
        internal IEnumerable<Node> GetEnumeratorNodeUlke(T ulke)//Sadece belirtilen ülkeye mensup düğümleri geri gönderir
        {
            for (Node traveler = first; traveler != null; traveler = traveler.next)
                if (traveler.ulke.Equals(ulke))
                    yield return traveler;
        }
        internal IEnumerable<string> GetEnumerator()//Bütün verileri depolanmaya hazır şekilde geri gönderir
        {
            for (Node traveler = first; traveler != null; traveler = traveler.next)
                yield return $"{traveler.tarih},{traveler.takim},{traveler.ulke}";
        }
        internal class Node
        {
            internal T ulke;
            internal T takim;
            internal T tarih;
            internal Node next = null;
            internal Node pre = null;
            internal Node(T tarih, T takim, T ulke)
            { this.tarih = tarih; this.takim = takim; this.ulke = ulke; }
        }
    }
}