using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGameLibrary.Graphics;

/// <summary>
/// テクスチャ内の矩形領域を表します。
/// </summary>
public class TextureRegion
{
    /// <summary>
    /// 新しいテクスチャ領域を作成します。
    /// </summary>
    public TextureRegion() { }

    /// <summary>
    /// 指定した元テクスチャを使用して新しいテクスチャ領域を作成します。
    /// </summary>
    /// <param name="texture">このテクスチャ領域の元となるテクスチャ。</param>
    /// <param name="x">元テクスチャの左上からの、このテクスチャ領域の左上隅のX座標。</param>
    /// <param name="y">元テクスチャの左上からの、このテクスチャ領域の左上隅のY座標。</param>
    /// <param name="width">このテクスチャ領域の幅（ピクセル単位）。</param>
    /// <param name="height">このテクスチャ領域の高さ（ピクセル単位）。</param>
    public TextureRegion(Texture2D texture, int x, int y, int width, int height)
    {
        Texture = texture;
        SourceRectangle = new Rectangle(x, y, width, height);
    }

    /// <summary>
    /// このテクスチャ領域が属する元のテクスチャを取得または設定します。
    /// </summary>
    public Texture2D Texture { get; set; }

    /// <summary>
    /// 元のテクスチャ内での、このテクスチャ領域の矩形範囲を取得または設定します。
    /// </summary>
    public Rectangle SourceRectangle { get; set; }

    /// <summary>
    /// このテクスチャ領域の幅（ピクセル単位）を取得します。
    /// </summary>
    public int Width => SourceRectangle.Width;

    /// <summary>
    /// このテクスチャ領域の高さ（ピクセル単位）を取得します。
    /// </summary>
    public int Height => SourceRectangle.Height;
}
