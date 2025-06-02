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

    #region メソッド
    /// <summary>
    /// Submit this texture region for drawing in the current batch.
    /// </summary>
    /// <param name="spriteBatch">The spritebatch instance used for batching draw calls.</param>
    /// <param name="position">The xy-coordinate location to draw this texture region on the screen.</param>
    /// <param name="color">The color mask to apply when drawing this texture region on screen.</param>
    public void Draw(SpriteBatch spriteBatch, Vector2 position, Color color)
    {
        Draw(spriteBatch, position, color, 0.0f, Vector2.Zero, Vector2.One, SpriteEffects.None, 0.0f);
    }

    /// <summary>
    /// Submit this texture region for drawing in the current batch.
    /// </summary>
    /// <param name="spriteBatch">The spritebatch instance used for batching draw calls.</param>
    /// <param name="position">The xy-coordinate location to draw this texture region on the screen.</param>
    /// <param name="color">The color mask to apply when drawing this texture region on screen.</param>
    /// <param name="rotation">The amount of rotation, in radians, to apply when drawing this texture region on screen.</param>
    /// <param name="origin">The center of rotation, scaling, and position when drawing this texture region on screen.</param>
    /// <param name="scale">The scale factor to apply when drawing this texture region on screen.</param>
    /// <param name="effects">Specifies if this texture region should be flipped horizontally, vertically, or both when drawing on screen.</param>
    /// <param name="layerDepth">The depth of the layer to use when drawing this texture region on screen.</param>
    public void Draw(SpriteBatch spriteBatch, Vector2 position, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth)
    {
        Draw(
            spriteBatch,
            position,
            color,
            rotation,
            origin,
            new Vector2(scale, scale),
            effects,
            layerDepth
        );
    }

    /// <summary>
    /// Submit this texture region for drawing in the current batch.
    /// </summary>
    /// <param name="spriteBatch">The spritebatch instance used for batching draw calls.</param>
    /// <param name="position">The xy-coordinate location to draw this texture region on the screen.</param>
    /// <param name="color">The color mask to apply when drawing this texture region on screen.</param>
    /// <param name="rotation">The amount of rotation, in radians, to apply when drawing this texture region on screen.</param>
    /// <param name="origin">The center of rotation, scaling, and position when drawing this texture region on screen.</param>
    /// <param name="scale">The amount of scaling to apply to the x- and y-axes when drawing this texture region on screen.</param>
    /// <param name="effects">Specifies if this texture region should be flipped horizontally, vertically, or both when drawing on screen.</param>
    /// <param name="layerDepth">The depth of the layer to use when drawing this texture region on screen.</param>
    public void Draw(SpriteBatch spriteBatch, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
    {
        spriteBatch.Draw(
            Texture,
            position,
            SourceRectangle,
            color,
            rotation,
            origin,
            scale,
            effects,
            layerDepth
        );
    }
    #endregion
}
