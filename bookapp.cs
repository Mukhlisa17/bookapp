using System;

namespace bookapp
{
     public static void Main()
    {
        Photobooks pb = new Photobooks();
        Console.WriteLine(pb.GetNumberPages());

        Photobooks pb2 = new Photobooks(24);
        Console.WriteLine(pb2.GetNumberPages());

        BigPhotoBook bpb = new BigPhotoBook();
        Console.WriteLine(bpb.GetNumberPages());
    }
}