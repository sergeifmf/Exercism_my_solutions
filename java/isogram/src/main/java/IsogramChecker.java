import java.util.ArrayList;

class IsogramChecker {

    // Checks if string is isogram
    boolean isIsogram(String phrase) {
        phrase = phrase.toLowerCase();

        var phraseLength = phrase.length();
        var permittedSymbols = new ArrayList () {
            {
                add(' ');
                add('-');
            }
        };

        for (var i = 0; i < phraseLength; i++) {
            var symbol = phrase.charAt(i);
            if (permittedSymbols.contains(symbol)) {
                continue;
            }

            if (phrase.indexOf(symbol, i + 1) != -1) {
                return false;
            }
        }

        return true;
    }

}
