package FileUtil;

import java.io.File;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;

public class FileUtil {
    public static byte[] readWithBytes(String fileName) throws Exception
    {
        Path path= Paths.get(fileName);
        byte [] bytes= Files.readAllBytes(path);
        return bytes;
    }
    public static void writeBytesToFile(String fileName,byte[] data) throws Exception
    {
        Path path=Paths.get(fileName);
        Files.write(path,data);
        System.out.println("Yazildi");
    }

}
