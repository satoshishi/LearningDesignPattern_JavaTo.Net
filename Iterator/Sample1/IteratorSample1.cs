using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator.Sample1
{
    /// <summary>
    /// 本の方を読んでみて、なんとなく書き換えてみたバージョン
    /// </summary>
    class IteratorSample1 :ISampleGenerater
    {
        public void generateSample()
        {
            #region BookShelf生成

            BookShelf fnGetComics()
            {
                BookShelf comics = new BookShelf();
                comics.appendBook(new Book("ナルト"));
                comics.appendBook(new Book("ブリーチ"));
                comics.appendBook(new Book("こち亀"));
                comics.appendBook(new Book("いちご100%"));

                return comics;
            }

            BookShelf fnGetJournal()
            {
                BookShelf journal = new BookShelf();
                journal.appendBook(new Journal("なんかすごい心理学論文", "なんかすご夫"));
                journal.appendBook(new Journal("なんかすごいハプティクス論文", "なんかすご実"));
                journal.appendBook(new Journal("なんかすごいロボティクス論文", "なんかすご太郎"));
                journal.appendBook(new Journal("なんかすごい脳科学論文", "なんかすご次郎"));

                return journal;
            }

            #endregion

            Console.Write("start \n");

            //ジェネリック使ってる関係で、ここが型引数に依存する・・・
            //iterator iterator = new SimpleIterator<Book>(bookShelf); <- これはかけない
            //Iterator<Book> iterator = new ReverseIterator<Book>(fnGetComics());
            //Iterator<Book> iterator = new SimpleIterator<Book>(fnGetJournal());
            Iterator<Book> iterator = new SimpleIterator<Book>(fnGetComics());

            while (!iterator.hasNext())
                Console.Write(iterator.next().getInfo() + "\n");
        }
    }
}
