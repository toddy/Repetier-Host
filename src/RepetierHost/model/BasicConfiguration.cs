/*
   Copyright 2011 repetier repetierdev@googlemail.com

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RepetierHost.view.utils;

namespace RepetierHost.model
{
    class BasicConfiguration
    {
        private string externalSlic3rPath="";
        private string externalSlic3rIniFile = "";
        private bool internalSlic3rUseBundledVersion = true;
        public static BasicConfiguration basicConf = new BasicConfiguration(); 
        public BasicConfiguration()
        {
            externalSlic3rPath = RegMemory.GetString("externalSlic3rPath", externalSlic3rPath);
            externalSlic3rIniFile = RegMemory.GetString("externalSlic3rIniFile", externalSlic3rIniFile);
            internalSlic3rUseBundledVersion = RegMemory.GetBool("internalSlic3rUseBundledVersion", internalSlic3rUseBundledVersion);
        }

        public string ExternalSlic3rPath
        {
            get { return externalSlic3rPath; }
            set { externalSlic3rPath = value; RegMemory.SetString("externalSlic3rPath", externalSlic3rPath); }
        }
        public string ExternalSlic3rIniFile
        {
            get { return externalSlic3rIniFile; }
            set { externalSlic3rIniFile = value; RegMemory.SetString("externalSlic3rIniFile", externalSlic3rIniFile); }
        }
        public bool InternalSlic3rUseBundledVersion
        {
            get { return internalSlic3rUseBundledVersion; }
            set { internalSlic3rUseBundledVersion = value; RegMemory.SetBool("internalSlic3rUseBundledVersion",internalSlic3rUseBundledVersion); }
        }
    }
}
