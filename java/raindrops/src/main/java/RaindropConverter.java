import java.io.Console;
import java.util.HashMap;
import java.util.Map;

class RaindropConverter {

    // Convert number to string that simulates raindrops
    String convert(int number) {
        var raindrops = new HashMap<Integer, String>() {
            {
                put(3, "Pling");
                put(5, "Plang");
                put(7, "Plong");
            }
        };

        var result = "";

        for (Map.Entry<Integer, String> entry : raindrops.entrySet()) {
            var key = entry.getKey();
            var value = entry.getValue();
            if (number % key == 0) {
                result = result.concat(value);
            }
        }

        if (result.isEmpty()) {
            return Integer.toString(number);
        }

        return result;
    }

}
