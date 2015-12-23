﻿/*
 *  This file is part of uEssentials project.
 *		https://uessentials.github.io/
 *
 *  Copyright (C) 2015-2016  Leonardosc
 *
 *  This program is free software; you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation; either version 2 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License along
 *  with this program; if not, write to the Free Software Foundation, Inc.,
 *  51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
*/

using Essentials.Core.Command;
using Essentials.Unturned;

namespace EssTestModule
{
    [CommandInfo(
        Name = "teest",
        Description = "Just an test",
        Target = CommandTarget.BOTH, // default
        Usage = "<msg>",
        Permission = "my.module.teest"
    )]
    public class TestCommand : EssCommand
    {
        public override void OnExecute( ICommandSource source, ICommandArgs parameters )
        {
            if ( parameters.IsEmpty )
            {
                source.SendMessage( "Hi :D" );
            }
            else
            {
                UServer.Broadcast( parameters.GetJoinedArguments( 0 ) );
            }
        }
    }
}
