/*
 * Copyright (c) Contributors, http://opensimulator.org/
 * See CONTRIBUTORS.TXT for a full list of copyright holders.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met:
 *     * Redistributions of source code must retain the above copyright
 *       notice, this list of conditions and the following disclaimer.
 *     * Redistributions in binary form must reproduce the above copyright
 *       notice, this list of conditions and the following disclaimer in the
 *       documentation and/or other materials provided with the distribution.
 *     * Neither the name of the OpenSimulator Project nor the
 *       names of its contributors may be used to endorse or promote products
 *       derived from this software without specific prior written permission.
 *
 * THIS SOFTWARE IS PROVIDED BY THE DEVELOPERS ``AS IS'' AND ANY
 * EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
 * DISCLAIMED. IN NO EVENT SHALL THE CONTRIBUTORS BE LIABLE FOR ANY
 * DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
 * (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
 * LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
 * ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
 * (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
 * SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */

using System;
using System.Collections.Generic;
using OpenMetaverse;
using OpenSim.Framework.Communications.Cache;

namespace OpenSim.Framework.Communications
{
    /// <summary>
    /// This class manages references to OpenSim non-region services (inventory, user, etc.)
    /// </summary>
    /// 
    /// TODO: Service retrieval needs to be managed via plugin and interfaces requests, as happens for region
    /// modules from scene.  Among other things, this will allow this class to be used in many different contexts
    /// (from a grid service executable, to provide services on a region) without lots of messy nulls and confusion.
    /// Also, a post initialize step on the plugins will be needed so that we don't get tortuous problems with 
    /// circular dependencies between plugins.
    public class CommunicationsManager
    {
        //private static readonly ILog m_log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public NetworkServersInfo NetworkServersInfo
        {
            get { return m_networkServersInfo; }
        }
        protected NetworkServersInfo m_networkServersInfo;
             
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="serversInfo"></param>
        public CommunicationsManager(NetworkServersInfo serversInfo,
                                     LibraryRootFolder libraryRootFolder)
        {
            m_networkServersInfo = serversInfo;
        }

    }
}
