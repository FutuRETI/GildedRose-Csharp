using NUnit.Framework;
using System.Collections.Generic;

/**
 * Questa classe contieiene un esempio di un test che potrete utilizzare come "traccia"
 * per l'implementazione dei vostri nuovi casi di test.
 * 
 * Come vedete il metodo di test (in questo caso chiamato foo) � suddiviso in tre parti distinte:
 * - given: � una parte preparatoria al caso di test vero e proprio, in questa parte del metodo
 *   vengono create tutte le precondizioni necessarie a permettere l'esecuzione del test vero
 *   e proprio
 * - when: � la parte in cui viene eseguita l'operazione che si sta testando; configurate tutte le
 *   precondizioni in questa parte viene eseguita una specifica funzionalit� sotto test (in questo
 *   caso viene eseguito il metodo UpdateQuality)
 * - then: � l'ultima parte del test e contiene le ferifiche che devono essere fatte per accertarsi
 *   che la funzionalit� sotto test abbia prodotto i risultati attesi (in questo caso � presente
 *   un'Assert che non verifica nessuna caratteristica rilevante del metodo UpdateQuality, ma test
 *   reali dovranno invece verificare propriet� significative della funzionalit� testata).
 *   
 * Consigliamo di sviluppare tutti i test mantenendo questa struttura (proprio comprensiva anche delle
 * tre righe di commento che permettano di identificare le varie parti del metodo di test).
 **/
namespace GildedRose
{
    [TestFixture]
    public class GildedRoseTest
    {
        [TestCase("foo", 0, 0)]
        public void foo(string ItemName, int ItemSellIn, int ItemQuality) {
            // given
            IList<Item> Items = new List<Item> { new Item { Name = ItemName, SellIn = ItemSellIn, Quality = ItemQuality } };
            GildedRose app = new GildedRose(Items);

            // when
            app.UpdateQuality();

            // then
            Assert.AreEqual(ItemName, Items[0].Name);
        }
    }
}
