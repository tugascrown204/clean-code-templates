public class HelloWorld {

    /**
     * Greet a person with a friendly message.
     *
     * @param name The name of the person to greet.
     * @return Greeting message.
     */
    public static String greet(String name) {
        return "Hello, " + name + "!";
    }

    public static void main(String[] args) {
        System.out.println(greet("World"));
    }
}