using System;
using System.Threading.Tasks;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
        PictureProvider provider = new PictureProvider();
        IPicture pictureOriginal = provider.GetPicture(@"./luke.jpg");
        provider.SavePicture(pictureOriginal, @"../imagenOriginal.jpg");
        PipeNull pipeNull = new PipeNull();
        FilterSave filterSave = new FilterSave();
        PipeSerial pipeSave1 = new PipeSerial(filterSave, pipeNull);
        IPicture pictureNull = pipeSave1.Send(pictureOriginal);
        FilterNegative filterNegative = new FilterNegative();
        PipeSerial pipeSave2 = new PipeSerial(filterNegative, pipeSave1);
        IPicture pictureNegative = pipeSave2.Send(pictureOriginal);
        FilterGreyscale filterGreyscale = new FilterGreyscale();
        PipeSerial pipeSave3 = new PipeSerial(filterGreyscale, pipeSave2);
        IPicture pictureGrayscale = pipeSave3.Send(pictureOriginal);
        FilterTwitter filterTwitter = new FilterTwitter();
        PipeSerial pipeSave4 = new PipeSerial(filterTwitter, pipeSave3);
        IPicture pictureTwitter = pipeSave4.Send(pictureOriginal);
        FilterFace filterFace = new FilterFace();
        PipeSerial pipeSave5 = new PipeSerial(filterFace, pipeSave4);
        IPicture pictureFace = pipeSave5.Send(pictureOriginal);
        }
    }
}
