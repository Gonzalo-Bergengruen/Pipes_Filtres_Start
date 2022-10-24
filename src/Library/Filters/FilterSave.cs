using System;

 namespace CompAndDel.Filters
 {
   public class FilterSave : IFilter
   {
      static int count = 0;
      public IPicture Filter(IPicture picture)
      {
         count += 1;
         string path = count + ".png";
         PictureProvider provider = new PictureProvider();
         provider.SavePicture(picture, path);
         return picture;
      }
   }
 }