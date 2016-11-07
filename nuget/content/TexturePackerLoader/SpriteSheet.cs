namespace TexturePackerLoader
{
  using System.Collections.Generic;
  using System.Collections.Specialized;

  using Microsoft.Xna.Framework.Graphics;
  using System.Collections;
  using System.Linq;

  public class SpriteSheet
  {
    private readonly OrderedDictionary spriteList;
    public SpriteSheet()
    {
      spriteList = new OrderedDictionary();
    }

    public void Add(string name, SpriteFrame sprite)
    {
      spriteList.Add(name, sprite);
    }

    public void Add(SpriteSheet otherSheet)
    {
      for (int i = 0; i < otherSheet.spriteList.Count; i++)
      {
        spriteList.Add(otherSheet.spriteList.Cast<DictionaryEntry>().ElementAt(i), otherSheet.spriteList[i]);
      }
    }

    public SpriteFrame Sprite(string sprite)
    {
      return (SpriteFrame)this.spriteList[sprite];
    }

    public SpriteFrame Sprite(int index)
    {
      return (SpriteFrame)this.spriteList[index];
    }

  }
}
