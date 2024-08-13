namespace ExperimentalProject
{
    public static class LinkedListExtensions
    {
        public static T GetSecondToLastElement<T>(this LinkedList<T> list)
        {
            if (list == null || list.Count < 2)
            {
                throw new InvalidOperationException("List does not have enough elements.");
            }

            /* We used the Null-Forgiving Operator because we're certain that no null 
               dereferencing will happen since we had already done null checking in 
               the beginning of the method and ensured that the list won't contain less
               than two elements */
            T secondToLastElement = list.Last!.Previous!.Value;

            return secondToLastElement;
        }
    }
}
