import java.util.ArrayList;

public class PigLatinTranslator {

    //
    public static String translate(String phrase) {
        var phraseLength = phrase.length();

        final var vowel = new ArrayList<>() {
            {
                add('a');
                add('e');
                add('i');
                add('o');
                add('u');
                add('y');
            }
        };

        final String pseudovowel = "xr";
        final char[] qu = {'q', 'u'};

        var isFirstLetterVowel = vowel.contains(phrase.charAt(0));
        var isSecondLetterVowel = false;
        char thirdLetter;
        var isFirstPairPseudoVowel = false;

        if (phraseLength > 1) {
            isSecondLetterVowel = vowel.contains(phrase.charAt(1));
            isFirstPairPseudoVowel = phrase.substring(0, 2) == pseudovowel;
        }

        if (phraseLength > 2) {
            thirdLetter = phrase.charAt(2);
        }

        if (!isFirstLetterVowel && firstPair != pseudovowel) {
            phrase = phrase.substring(1) + phrase.charAt(0);
        }

        if (!vowel.contains(secondLetter) ) {
            phrase = phrase.substring(1) + secondLetter;
        }

        if (secondLetter == qu[0] && thirdLetter == qu[1]) {
            phrase = phrase.substring(1) + thirdLetter;
        }

        phrase += "ay";

        return phrase;
    }
}
