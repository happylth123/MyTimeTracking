using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTimeTracking.Infrastructures
{
    public interface IPagedList
    {
        int CurrentPageIndex { get; set; }

        int PageSize { get; set; }

        int TotalItemCount { get; set; }

        int TotalPageCount { get; }

        int StartRecordIndex { get; }

        int EndRecordIndex { get; }

        bool HasPrev { get; }

        bool HasNext { get; }

        int PrevPageIndex { get; }

        int NextPageIndex { get; }
    }

    public class PagedList<T> : IEnumerable<T>, IPagedList
    {
        private IEnumerable<T> list;

        public PagedList(IList<T> items, int pageIndex, int pageSize)
        {
            PageSize = pageSize;
            TotalItemCount = items.Count;
            TotalPageCount = (int)Math.Ceiling(TotalItemCount / (double)PageSize);
            CurrentPageIndex = pageIndex;
            StartRecordIndex = ((CurrentPageIndex - 1) * PageSize) + 1;
            EndRecordIndex = TotalItemCount > pageIndex * pageSize ? pageIndex * pageSize : TotalItemCount;
            list = items.Skip(StartRecordIndex - 1).Take(pageSize).ToArray();
        }

        public PagedList(IEnumerable<T> items, int pageIndex, int pageSize, int totalItemCount)
        {
            list = items;
            TotalItemCount = totalItemCount;
            TotalPageCount = (int)Math.Ceiling(totalItemCount / (double)pageSize);
            CurrentPageIndex = pageIndex;
            PageSize = pageSize;
            StartRecordIndex = ((pageIndex - 1) * pageSize) + 1;
            EndRecordIndex = TotalItemCount > pageIndex * pageSize ? pageIndex * pageSize : totalItemCount;
            HasPrev = CurrentPageIndex > 1;
            HasNext = CurrentPageIndex < TotalPageCount;
            PrevPageIndex = HasPrev ? (CurrentPageIndex - 1) : 1;
            NextPageIndex = HasNext ? (CurrentPageIndex + 1) : TotalPageCount;
        }

        public int CurrentPageIndex { get; set; }

        public int PageSize { get; set; }

        public int TotalItemCount { get; set; }

        public int TotalPageCount { get; private set; }

        public int StartRecordIndex { get; private set; }

        public int EndRecordIndex { get; private set; }

        public bool HasPrev { get; private set; }

        public bool HasNext { get; private set; }

        public int PrevPageIndex { get; private set; }

        public int NextPageIndex { get; private set; }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return this.list.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.list.GetEnumerator();
        }
    }
}
