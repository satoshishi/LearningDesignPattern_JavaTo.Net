using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp;

namespace ConsoleApp.Iterator_Sample
{
    //書いてみた感想
    //・ループ処理とそれ以外を分離することで、ループ処理を再利用できるのはいいなと感じた。
    //・再利用できる形をとることで、ループを回す処理自体の動作保証がとれるのは、結構配列境界外みたいなエラーを出す自分的には、ありがたい
    //・本のサンプルはIterator側がAggregate側に結構依存する形で気持ち悪かったので、依存する要素をプロパティだけにしてAggregate側の改修
    //　に依存しないようにしてみたが、Genericを使った関係で呼び出し側に依存が出てしまったのが、どうにかしたかった。
    class IteratorSample :ISampleGenerater
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
