﻿// Author: Daniele Giardini - http://www.demigiant.com
// Created: 2017/01/11 12:57
// License Copyright (c) Daniele Giardini

using System;
using System.Linq;
using System.Text;
using UnityEngine;

namespace DG.DemiLib.Attributes
{
    /// <summary>
    /// <code>Decorator + Method caller</code>
    /// Draws a button which will call the given method
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public class DeButtonAttribute : PropertyAttribute
    {
        internal Type targetType;
        internal string text;
        internal string methodName;
        internal object[] parameters;
        internal string textShade, bgShade;
        internal DePosition position = DePosition.HExtended;

        /// <summary>
        /// Draws a button which will call the given method. Method can be public/private/instance/static/whatever and on any class type
        /// </summary>
        /// <param name="position"><see cref="DePosition"/> of the button relative to Inspector width</param>
        /// <param name="textShade">Color shade (hex string, without #) for the button text</param>
        /// <param name="bgShade">Color shade (hex string, without #) for the button background</param>
        /// <param name="targetType">Type of the class that implements the method to call</param>
        /// <param name="methodName">Name of the method to call</param>
        /// <param name="buttonText">Button text</param>
        /// <param name="parameters">Eventual parameters to pass to the method</param>
        public DeButtonAttribute(DePosition position, string textShade, string bgShade, Type targetType, string methodName, string buttonText, params object[] parameters)
        {
            this.text = buttonText;
            this.targetType = targetType;
            this.methodName = methodName;
            this.parameters = parameters;
            this.position = position;
            this.textShade = textShade;
            this.bgShade = bgShade;
        }
        /// <summary>
        /// Draws a button which will call the given method. Method can be public/private/instance/static/whatever and on any class type
        /// </summary>
        /// <param name="position"><see cref="DePosition"/> of the button relative to Inspector width</param>
        /// <param name="textShade">Color shade (hex string, without #) for the button text</param>
        /// <param name="bgShade">Color shade (hex string, without #) for the button background</param>
        /// <param name="targetType">Type of the class that implements the method to call</param>
        /// <param name="methodName">Name of the method to call</param>
        /// <param name="parameters">Eventual parameters to pass to the method</param>
        public DeButtonAttribute(DePosition position, string textShade, string bgShade, Type targetType, string methodName, params object[] parameters)
        {
            this.text = NicifyMethodName(methodName);
            this.targetType = targetType;
            this.methodName = methodName;
            this.parameters = parameters;
            this.position = position;
            this.textShade = textShade;
            this.bgShade = bgShade;
        }
        /// <summary>
        /// Draws a button which will call the given method. Method can be public/private/instance/static/whatever and on any class type
        /// </summary>
        /// <param name="textShade">Color shade (hex string, without #) for the button text</param>
        /// <param name="bgShade">Color shade (hex string, without #) for the button background</param>
        /// <param name="targetType">Type of the class that implements the method to call</param>
        /// <param name="methodName">Name of the method to call</param>
        /// <param name="buttonText">Button text</param>
        /// <param name="parameters">Eventual parameters to pass to the method</param>
        public DeButtonAttribute(string textShade, string bgShade, Type targetType, string methodName, string buttonText, params object[] parameters)
        {
            this.text = buttonText;
            this.targetType = targetType;
            this.methodName = methodName;
            this.parameters = parameters;
            this.textShade = textShade;
            this.bgShade = bgShade;
        }
        /// <summary>
        /// Draws a button which will call the given method. Method can be public/private/instance/static/whatever and on any class type
        /// </summary>
        /// <param name="textShade">Color shade (hex string, without #) for the button text</param>
        /// <param name="bgShade">Color shade (hex string, without #) for the button background</param>
        /// <param name="targetType">Type of the class that implements the method to call</param>
        /// <param name="methodName">Name of the method to call</param>
        /// <param name="parameters">Eventual parameters to pass to the method</param>
        public DeButtonAttribute(string textShade, string bgShade, Type targetType, string methodName, params object[] parameters)
        {
            this.text = NicifyMethodName(methodName);
            this.targetType = targetType;
            this.methodName = methodName;
            this.parameters = parameters;
            this.textShade = textShade;
            this.bgShade = bgShade;
        }
        /// <summary>
        /// Draws a button which will call the given method. Method can be public/private/instance/static/whatever and on any class type
        /// </summary>
        /// <param name="position"><see cref="DePosition"/> of the button relative to Inspector width</param>
        /// <param name="targetType">Type of the class that implements the method to call</param>
        /// <param name="methodName">Name of the method to call</param>
        /// <param name="buttonText">Button text</param>
        /// <param name="parameters">Eventual parameters to pass to the method</param>
        public DeButtonAttribute(DePosition position, Type targetType, string methodName, string buttonText, params object[] parameters)
        {
            this.text = buttonText;
            this.targetType = targetType;
            this.methodName = methodName;
            this.parameters = parameters;
            this.position = position;
        }
        /// <summary>
        /// Draws a button which will call the given method. Method can be public/private/instance/static/whatever and on any class type
        /// </summary>
        /// <param name="position"><see cref="DePosition"/> of the button relative to Inspector width</param>
        /// <param name="targetType">Type of the class that implements the method to call</param>
        /// <param name="methodName">Name of the method to call</param>
        /// <param name="parameters">Eventual parameters to pass to the method</param>
        public DeButtonAttribute(DePosition position, Type targetType, string methodName, params object[] parameters)
        {
            this.text = NicifyMethodName(methodName);
            this.targetType = targetType;
            this.methodName = methodName;
            this.parameters = parameters;
            this.position = position;
        }
        /// <summary>
        /// Draws a button which will call the given method. Method can be public/private/instance/static/whatever and on any class type
        /// </summary>
        /// <param name="targetType">Type of the class that implements the method to call</param>
        /// <param name="methodName">Name of the method to call</param>
        /// <param name="buttonText">Button text</param>
        /// <param name="parameters">Eventual parameters to pass to the method</param>
        public DeButtonAttribute(Type targetType, string methodName, string buttonText, params object[] parameters)
        {
            this.text = buttonText;
            this.targetType = targetType;
            this.methodName = methodName;
            this.parameters = parameters;
        }
        /// <summary>
        /// Draws a button which will call the given method. Method can be public/private/instance/static/whatever and on any class type
        /// </summary>
        /// <param name="targetType">Type of the class that implements the method to call</param>
        /// <param name="methodName">Name of the method to call</param>
        /// <param name="parameters">Eventual parameters to pass to the method</param>
        public DeButtonAttribute(Type targetType, string methodName, params object[] parameters)
        {
            this.text = NicifyMethodName(methodName);
            this.targetType = targetType;
            this.methodName = methodName;
            this.parameters = parameters;
        }

        #region Helpers

        static string NicifyMethodName(string s)
        {
            if (string.IsNullOrEmpty(s)) return "";
            StringBuilder result = new StringBuilder(s.Length * 2);
            result.Append(s[0]);
            for (int i = 1; i < s.Length; i++) {
                if (char.IsUpper(s[i]) && s[i - 1] != ' ') result.Append(' ');
                result.Append(s[i]);
            }
            return result.ToString();
        }

        #endregion
    }
}