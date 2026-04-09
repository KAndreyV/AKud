import java.nio.charset.Charset;
import java.nio.file.Files;
import java.nio.file.Path;
import java.util.List;

public class Main {
    public static void main(String[] args) throws Exception {
        Path input = Path.of("C:\\tmp\\RusDictionary.txt");
        Path output = Path.of("C:\\tmp\\LongWords.txt");
        Charset charset = Charset.forName("windows-1251");

        List<String> longWords = Files.readAllLines(input, charset).stream()
                .map(String::trim)
                .filter(word -> word.length() > 18)
                .toList();

        Files.write(output, longWords, charset);
    }
}