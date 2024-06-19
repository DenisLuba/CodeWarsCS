using System.ComponentModel.Design;

namespace CodeWars
{
    public static class UniqueInOrder
    {
        public static IEnumerable<T> UniqueInOrderMethod<T>(this IEnumerable<T> iterable)
            => iterable.Where((t, i) => i == 0 || !Equals(t, iterable.ElementAt(i - 1)));

        //public static IEnumerable<T> UniqueInOrderMethod<T>(IEnumerable<T> iterable)
        //    => iterable
        //    .Aggregate(new List<T>(),
        //        (list, b) => list.GetList(b));

        //private static List<T> GetList<T>(this List<T> list, T item)
        //{
        //    if (list.Count() != 0 && list.Last()!.Equals(item))
        //        return list;
        //    else
        //    {
        //        list.Add(item);
        //        return list;
        //    }
        //}
    }
}
