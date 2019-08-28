using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class CustomList : IEnumerable
    {
       private ArrayList movieList = new ArrayList();

        public ArrayList MovieList { get => movieList; set => movieList = value; }

        public void Add(IMovie movie)
        {
            MovieList.Add(movie);
        }

        public  IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Remove(IMovie movie)
        {
            MovieList.Remove(movie);
        }

        public void Sort()
        {
            //var compare = new CustomSort();
            MovieList.Sort(new CustomSort());
        }

    }


}
