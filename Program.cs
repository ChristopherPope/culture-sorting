using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var delims = new string[] { Environment.NewLine };
            var langs = rawLangs
                .Split(delims, StringSplitOptions.RemoveEmptyEntries)
                .ToList();


        }


        #region Raw
        static private string rawLangs = @"Afrikaans				
Albanian				
Amharic				
Arabic				
Armenian		
Assamese			
Azerbaijani (Latin)					
Bangla			
Bashkir			
Basque				
Bhojpuri			
Bodo			
Bosnian (Latin)			
Bulgarian				
Cantonese (Traditional)				
Catalan				
Chinese (Literary)				
Chinese Simplified				
Chinese Traditional			
chiShona			
Croatian				
Czech					
Danish					
Dari					
Divehi					
Dogri					
Dutch					
English					
Estonian					
Faroese					
Fijian					
Filipino					
Finnish					
French					
French (Canada)					
Galician					
Georgian					
German					
Greek					
Gujarati					
Haitian Creole					
Hausa					
Hebrew					
Hindi					
Hmong Daw (Latin)					
Hungarian					
Icelandic					
Igbo					
Indonesian					
Inuinnaqtun					
Inuktitut					
Inuktitut (Latin)				
Irish					
Italian					
Japanese					
Kannada					
Kashmiri					
Kazakh					
Khmer					
Kinyarwanda					
Klingon					
Klingon (plqaD)				
Konkani					
Korean					
Kurdish (Central)					
Kurdish (Northern)					
Kyrgyz (Cyrillic)					
Lao					
Latvian					
Lithuanian					
Lingala					
Lower Sorbian					
Luganda					
Macedonian					
Maithili					
Malagasy					
Malay (Latin)					
Malayalam					
Maltese					
Maori					
Marathi					
Mongolian (Cyrillic)				
Mongolian (Traditional)					
Myanmar					
Nepali					
Norwegian Bokmål					
Nyanja					
Odia					
Pashto					
Persian					
Polish					
Portuguese (Brazil)					
Portuguese (Portugal)			
Punjabi					
Queretaro Otomi					
Romanian					
Rundi					
Russian					
Samoan (Latin)					
Serbian (Cyrillic)				
Serbian (Latin)				
Sesotho					
Sesotho 
Leboa					
Setswana					
Sindhi					
Sinhala					
Slovak					
Slovenian					
Somali (Arabic)					
Spanish					
Swahili (Latin)					
Swedish					
Tahitian					
Tamil					
Tatar (Latin)					
Telugu					
Thai					
Tibetan					
Tigrinya					
Tongan					
Turkish					
Turkmen (Latin)					
Ukrainian					
Upper Sorbian					
Urdu					
Uyghur (Arabic)					
Uzbek (Latin)					
Vietnamese					
Welsh					
Xhosa					
Yoruba					
Yucatec Maya					
Zulu					";
        #endregion
    }
}
