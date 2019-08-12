// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Reflection.Tests
{
    public class MethodTestBaseClass
    {
        public static int Members = 38;
        public static int MembersEverything = 44;

        public static string[] DeclaredMethodNames = new string[] { "Void PrivMeth1()",
                                                                    "Void PrivMeth3()",
                                                                    "Void PubBaseMeth1()",
                                                                    "Void PubBaseMeth1(System.String)",
                                                                    "Void IntBaseMeth1()",
                                                                    "Void IntBaseMeth1(System.String)",
                                                                    "Void ProtectedBaseMeth1()",
                                                                    "Void ProtectedBaseMeth1(System.String)",
                                                                    "Void PriBaseMeth1()",
                                                                    "Void PriBaseMeth1(System.String)",
                                                                    "Void PubMeth1()",
                                                                    "Void PubMeth2()",
                                                                    "Void PubMeth3()",
                                                                    "Void IntMeth1()",
                                                                    "Void IntMeth2()",
                                                                    "Void IntMeth3()",
                                                                    "Void ProMeth1()",
                                                                    "Void ProMeth2()",
                                                                    "Void ProMeth3()",
                                                                    "Void ProIntMeth1()",
                                                                    "Void ProIntMeth2()",
                                                                    "Void ProIntMeth3()",
                                                                    "Void PubMeth2ToOverride()",
                                                                    "Void IntMeth2ToOverride()",
                                                                    "Void ProMeth2ToOverride()",
                                                                    "Void ProIntMeth2ToOverride()"};

        public static string[] InheritedMethodNames = new string[] { };

        public static string[] PublicMethodNames = new string[] {   "Void PubBaseMeth1()",
                                                                    "Void PubBaseMeth1(System.String)",
                                                                    "Void PubMeth1()",
                                                                    "Void PubMeth2()",
                                                                    "Void PubMeth3()",
                                                                    "Void PubMeth2ToOverride()"};
        public void PubBaseMeth1() { }
        public void PubBaseMeth1(string str) { }

        internal void IntBaseMeth1() { }
        internal void IntBaseMeth1(string str) { }

        protected void ProtectedBaseMeth1() { }
        protected void ProtectedBaseMeth1(string str) { }

        private void PriBaseMeth1() { }
        private void PriBaseMeth1(string str) { }

        public void PubMeth1() { }
        public virtual void PubMeth2() { }
        public virtual void PubMeth2ToOverride() { }
        public static void PubMeth3() { }

        internal void IntMeth1() { }
        internal virtual void IntMeth2() { }
        internal virtual void IntMeth2ToOverride() { }
        internal static void IntMeth3() { }

        protected void ProMeth1() { }
        protected virtual void ProMeth2() { }
        protected virtual void ProMeth2ToOverride() { }
        protected static void ProMeth3() { }

        protected internal void ProIntMeth1() { }
        protected internal virtual void ProIntMeth2() { }
        protected internal virtual void ProIntMeth2ToOverride() { }
        protected internal static void ProIntMeth3() { }

        private void PrivMeth1() { }
        private static void PrivMeth3() { }
    }

    public class MethodTestSubClass : MethodTestBaseClass
    {
        public static new int Members = 31;
        public static new int MembersEverything = 51;

        public static new string[] DeclaredMethodNames = new string[]{  "Void PubMeth1()",
                                                                    "Void PubMeth2()",
                                                                    "Void PubMeth3()",
                                                                    "Void IntMeth1()",
                                                                    "Void IntMeth2()",
                                                                    "Void IntMeth3()",
                                                                    "Void ProMeth1()",
                                                                    "Void ProMeth2()",
                                                                    "Void ProMeth3()",
                                                                    "Void ProIntMeth1()",
                                                                    "Void ProIntMeth2()",
                                                                    "Void ProIntMeth3()",
                                                                    "Void PrivMeth1()",
                                                                    "Void PrivMeth3()",
                                                                    "Void PubMeth2ToOverride()",
                                                                    "Void IntMeth2ToOverride()",
                                                                    "Void ProMeth2ToOverride()",
                                                                    "Void ProIntMeth2ToOverride()"};

        public static new string[] InheritedMethodNames = new string[] {    "Void PubBaseMeth1()",
                                                                        "Void PubBaseMeth1(System.String)",
                                                                        "Void IntBaseMeth1()",
                                                                        "Void IntBaseMeth1(System.String)",
                                                                        "Void ProtectedBaseMeth1()",
                                                                        "Void ProtectedBaseMeth1(System.String)"};

        public static new string[] PublicMethodNames = new string[]{ "Void PubMeth1()",
                                                                 "Void PubMeth2()",
                                                                 "Void PubMeth3()",
                                                                 "Void PubMeth2ToOverride()"};

        //They exist in base, new slot is allocated in sub class
        public static string[] NewMethodNames = new string[] { "Void PubMeth1()",
                                                               "Void PubMeth2()",
                                                               "Void IntMeth1()",
                                                               "Void IntMeth2()",
                                                               "Void ProMeth1()",
                                                               "Void ProMeth2()",
                                                               "Void ProIntMeth1()",
                                                               "Void ProIntMeth2()",};
        public new void PubMeth1() { }
        public new virtual void PubMeth2() { }
        public override void PubMeth2ToOverride() { }
        public static new void PubMeth3() { }

        internal new void IntMeth1() { }
        internal new virtual void IntMeth2() { }
        internal override void IntMeth2ToOverride() { }
        internal static new void IntMeth3() { }

        protected new void ProMeth1() { }
        protected new virtual void ProMeth2() { }
        protected override void ProMeth2ToOverride() { }
        protected static new void ProMeth3() { }

        protected internal new void ProIntMeth1() { }
        protected internal new virtual void ProIntMeth2() { }
        protected internal override void ProIntMeth2ToOverride() { }
        protected internal static new void ProIntMeth3() { }

        private void PrivMeth1() { }
        private static void PrivMeth3() { }
    }

    public abstract class MethodTestAbsBaseClass
    {
        public static int Members = 11;
        public static int MembersEverything = 17;

        public static string[] DeclaredMethodNames = new string[] { "Void meth1()", "Void meth2()", "Void meth3()", "Void meth4()" };
        public static string[] InheritedMethodNames = new string[] { };
        public static string[] PublicMethodNames = new string[] { "Void meth1()" };

        public abstract void meth1();
        internal abstract void meth2();
        protected abstract void meth3();
        protected internal abstract void meth4();
    }

    public abstract class MethodTestAbsSubClass : MethodTestAbsBaseClass
    {
        public static new int Members = 7;
        public static new int MembersEverything = 17;

        public static new string[] DeclaredMethodNames = new string[] { };
        public static new string[] InheritedMethodNames = new string[] { "Void meth1()", "Void meth2()", "Void meth3()", "Void meth4()" };
        public static new string[] PublicMethodNames = new string[] { };
    }
}
