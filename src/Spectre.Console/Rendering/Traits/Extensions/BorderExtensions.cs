using System;

namespace Spectre.Console
{
    /// <summary>
    /// Contains extension methods for <see cref="IHasBorder"/>.
    /// </summary>
    public static class BorderExtensions
    {
        /// <summary>
        /// Do not display a border.
        /// </summary>
        /// <typeparam name="T">An object type with a border.</typeparam>
        /// <param name="obj">The object to set the border for.</param>
        /// <returns>The same instance so that multiple calls can be chained.</returns>
        public static T NoBorder<T>(this T obj)
            where T : class, IHasBorder
        {
            return SetBorder(obj, Border.None);
        }

        /// <summary>
        /// Display a square border.
        /// </summary>
        /// <typeparam name="T">An object type with a border.</typeparam>
        /// <param name="obj">The object to set the border for.</param>
        /// <returns>The same instance so that multiple calls can be chained.</returns>
        public static T SquareBorder<T>(this T obj)
            where T : class, IHasBorder
        {
            return SetBorder(obj, Border.Square);
        }

        /// <summary>
        /// Display an ASCII border.
        /// </summary>
        /// <typeparam name="T">An object type with a border.</typeparam>
        /// <param name="obj">The object to set the border for.</param>
        /// <returns>The same instance so that multiple calls can be chained.</returns>
        public static T AsciiBorder<T>(this T obj)
            where T : class, IHasBorder
        {
            return SetBorder(obj, Border.Ascii);
        }

        /// <summary>
        /// Display a rounded border.
        /// </summary>
        /// <typeparam name="T">An object type with a border.</typeparam>
        /// <param name="obj">The object to set the border for.</param>
        /// <returns>The same instance so that multiple calls can be chained.</returns>
        public static T RoundedBorder<T>(this T obj)
            where T : class, IHasBorder
        {
            return SetBorder(obj, Border.Rounded);
        }

        /// <summary>
        /// Sets the border.
        /// </summary>
        /// <typeparam name="T">An object type with a border.</typeparam>
        /// <param name="obj">The object to set the border for.</param>
        /// <param name="border">The border to use.</param>
        /// <returns>The same instance so that multiple calls can be chained.</returns>
        public static T SetBorder<T>(this T obj, Border border)
            where T : class, IHasBorder
        {
            if (obj is null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            obj.Border = border;
            return obj;
        }

        /// <summary>
        /// Disables the safe border.
        /// </summary>
        /// <typeparam name="T">An object type with a border.</typeparam>
        /// <param name="obj">The object to set the border for.</param>
        /// <returns>The same instance so that multiple calls can be chained.</returns>
        public static T NoSafeBorder<T>(this T obj)
            where T : class, IHasBorder
        {
            if (obj is null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            obj.UseSafeBorder = false;
            return obj;
        }

        /// <summary>
        /// Sets the border style.
        /// </summary>
        /// <typeparam name="T">An object type with a border.</typeparam>
        /// <param name="obj">The object to set the border color for.</param>
        /// <param name="style">The border style to set.</param>
        /// <returns>The same instance so that multiple calls can be chained.</returns>
        public static T SetBorderStyle<T>(this T obj, Style style)
            where T : class, IHasBorder
        {
            if (obj is null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            obj.BorderStyle = style;
            return obj;
        }

        /// <summary>
        /// Sets the border color.
        /// </summary>
        /// <typeparam name="T">An object type with a border.</typeparam>
        /// <param name="obj">The object to set the border color for.</param>
        /// <param name="color">The border color to set.</param>
        /// <returns>The same instance so that multiple calls can be chained.</returns>
        public static T SetBorderColor<T>(this T obj, Color color)
            where T : class, IHasBorder
        {
            if (obj is null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            obj.BorderStyle = (obj.BorderStyle ?? Style.Plain).WithForeground(color);
            return obj;
        }
    }
}
