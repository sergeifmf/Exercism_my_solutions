class Twofer {

    // Creates Two-fer string
    String twofer(String name) {
        final var mainString = "One for , one for me.";
        final var offset = mainString.indexOf(',');

        if (name == null) {
            name = "you";
        }

        var result = new StringBuilder(mainString).insert(offset, name);

        return result.toString();
    }
}
