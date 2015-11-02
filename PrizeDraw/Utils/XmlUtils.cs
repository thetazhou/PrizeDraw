using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace PrizeDraw.Utils
{
    /// <summary>
    /// Xml操作类
    /// </summary>
    public class XmlUtils
    {
        /// <summary>
        /// 获取指定节点的值
        /// </summary>
        /// <param name="node">节点</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static String GetXmlNodeValue(XmlNode node, String defaultValue)
        {
            if (node == null)
            {
                return defaultValue;
            }
            if (node.InnerText.Trim() == String.Empty)
            {
                return defaultValue;
            }
            return node.InnerText.Trim();
        }
        /// <summary>
        /// 获取指定节点的值
        /// </summary>
        /// <param name="node">节点</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static Boolean GetXmlNodeValue(XmlNode node, Boolean defaultValue)
        {
            String value = GetXmlNodeValue(node, String.Empty);
            if (value == String.Empty)
            {
                return defaultValue;
            }
            bool result = defaultValue;
            if (!bool.TryParse(value, out result))
            {
                result = defaultValue;
            }
            return result;
        }
        /// <summary>
        /// 获取指定节点的值
        /// </summary>
        /// <param name="node">节点</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static Byte GetXmlNodeValue(XmlNode node, Byte defaultValue)
        {
            String value = GetXmlNodeValue(node, String.Empty);
            if (value == String.Empty)
            {
                return defaultValue;
            }
            Byte result = defaultValue;
            if (!Byte.TryParse(value, out result))
            {
                result = defaultValue;
            }
            return result;
        }
        /// <summary>
        /// 获取指定节点的值
        /// </summary>
        /// <param name="node">节点</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static Int32 GetXmlNodeValue(XmlNode node, Int32 defaultValue)
        {
            String value = GetXmlNodeValue(node, String.Empty);
            if (value == String.Empty)
            {
                return defaultValue;
            }
            Int32 result = defaultValue;
            if (!Int32.TryParse(value, out result))
            {
                result = defaultValue;
            }
            return result;
        }
        /// <summary>
        /// 获取指定节点的值
        /// </summary>
        /// <param name="node">节点</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static Single GetXmlNodeValue(XmlNode node, Single defaultValue)
        {
            String value = GetXmlNodeValue(node, String.Empty);
            if (value == String.Empty)
            {
                return defaultValue;
            }
            Single result = defaultValue;
            if (!Single.TryParse(value, out result))
            {
                result = defaultValue;
            }
            return result;
        }
        /// <summary>
        /// 获取指定节点的值
        /// </summary>
        /// <param name="node">节点</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static Double GetXmlNodeValue(XmlNode node, Double defaultValue)
        {
            String value = GetXmlNodeValue(node, String.Empty);
            if (value == String.Empty)
            {
                return defaultValue;
            }
            Double result = defaultValue;
            if (!Double.TryParse(value, out result))
            {
                result = defaultValue;
            }
            return result;
        }
        /// <summary>
        /// 获取指定节点的值
        /// </summary>
        /// <param name="node">节点</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static DateTime GetXmlNodeValue(XmlNode node, DateTime defaultValue, String format)
        {
            String value = GetXmlNodeValue(node, String.Empty);
            if (value == String.Empty)
            {
                return defaultValue;
            }
            DateTime result = defaultValue;
            if (!DateTime.TryParseExact(value, format, null, System.Globalization.DateTimeStyles.None, out result))
            {
                result = defaultValue;
            }
            return result;
        }

        /// <summary>
        /// 获取指定结点中指定属性的值
        /// </summary>
        /// <param name="node">节点</param>
        /// <param name="attributeName">属性</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static String GetXmlAttributeValue(XmlNode node, String attributeName, String defaultValue)
        {
            if (node == null)
            {
                return defaultValue;
            }
            XmlAttribute attribute = node.Attributes[attributeName];
            if (attribute == null)
            {
                return defaultValue;
            }
            if (attribute.Value.Trim() == String.Empty)
            {
                return defaultValue;
            }
            return attribute.Value.Trim();
        }
        /// <summary>
        /// 获取指定结点中指定属性的值
        /// </summary>
        /// <param name="node">节点</param>
        /// <param name="attributeName">属性</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static Boolean GetXmlAttributeValue(XmlNode node, String attributeName, Boolean defaultValue)
        {
            String value = GetXmlAttributeValue(node, attributeName, String.Empty);
            if (value == String.Empty)
            {
                return defaultValue;
            }
            Boolean result = defaultValue;
            if (!Boolean.TryParse(value, out result))
            {
                result = defaultValue;
            }
            return result;
        }
        /// <summary>
        /// 获取指定结点中指定属性的值
        /// </summary>
        /// <param name="node">节点</param>
        /// <param name="attributeName">属性</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static Byte GetXmlAttributeValue(XmlNode node, String attributeName, Byte defaultValue)
        {
            String value = GetXmlAttributeValue(node, attributeName, String.Empty);
            if (value == String.Empty)
            {
                return defaultValue;
            }
            Byte result = defaultValue;
            if (!Byte.TryParse(value, out result))
            {
                result = defaultValue;
            }
            return result;
        }
        /// <summary>
        /// 获取指定结点中指定属性的值
        /// </summary>
        /// <param name="node">节点</param>
        /// <param name="attributeName">属性</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static Int32 GetXmlAttributeValue(XmlNode node, String attributeName, Int32 defaultValue)
        {
            String value = GetXmlAttributeValue(node, attributeName, String.Empty);
            if (value == String.Empty)
            {
                return defaultValue;
            }
            Int32 result = defaultValue;
            if (!Int32.TryParse(value, out result))
            {
                result = defaultValue;
            }
            return result;
        }
        /// <summary>
        /// 获取指定结点中指定属性的值
        /// </summary>
        /// <param name="node">节点</param>
        /// <param name="attributeName">属性</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static Single GetXmlAttributeValue(XmlNode node, String attributeName, Single defaultValue)
        {
            String value = GetXmlAttributeValue(node, attributeName, String.Empty);
            if (value == String.Empty)
            {
                return defaultValue;
            }
            Single result = defaultValue;
            if (!Single.TryParse(value, out result))
            {
                result = defaultValue;
            }
            return result;
        }
        /// <summary>
        /// 获取指定结点中指定属性的值
        /// </summary>
        /// <param name="node">节点</param>
        /// <param name="attributeName">属性</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static Double GetXmlAttributeValue(XmlNode node, String attributeName, Double defaultValue)
        {
            String value = GetXmlAttributeValue(node, attributeName, String.Empty);
            if (value == String.Empty)
            {
                return defaultValue;
            }
            Double result = defaultValue;
            if (!Double.TryParse(value, out result))
            {
                result = defaultValue;
            }
            return result;
        }
        /// <summary>
        /// 获取指定结点中指定属性的值
        /// </summary>
        /// <param name="node">节点</param>
        /// <param name="attributeName">属性</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static TimeSpan GetXmlAttributeValue(XmlNode node, String attributeName, TimeSpan defaultValue)
        {
            String value = GetXmlAttributeValue(node, attributeName, String.Empty);
            if (value == String.Empty)
            {
                return defaultValue;
            }
            TimeSpan result = defaultValue;
            if (!TimeSpan.TryParse(value, out result))
            {
                result = defaultValue;
            }
            return result;
        }
        /// <summary>
        /// 获取指定结点中指定属性的值
        /// </summary>
        /// <param name="node">节点</param>
        /// <param name="attributeName">属性</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static DateTime GetXmlAttributeValue(XmlNode node, String attributeName, DateTime defaultValue, String format)
        {
            String value = GetXmlAttributeValue(node, attributeName, String.Empty);
            if (value == String.Empty)
            {
                return defaultValue;
            }
            DateTime result = defaultValue;
            if (!DateTime.TryParseExact(value, format, null, System.Globalization.DateTimeStyles.None, out result))
            {
                result = defaultValue;
            }
            return result;
        }

    }
}
