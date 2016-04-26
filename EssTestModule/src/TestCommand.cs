/*
 *  This file is part of uEssentials project.
 *      https://uessentials.github.io/
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

using Essentials.Api.Command;
using Essentials.Api.Command.Source;
using Essentials.Api.Unturned;

namespace EssTestModule
{
    [CommandInfo(
        Name = "teest",
        Description = "Just an test",
        AllowedSource = AllowedSource.PLAYER, // default is BOTH
        Usage = "<msg>",
        Permission = "my.module.teest"
    )]
    public class TestCommand : EssCommand
    {
        public override CommandResult OnExecute( ICommandSource src, ICommandArgs args )
        {
            if ( args.IsEmpty )
            {
                src.SendMessage( "Hi :D" );
            }
            else
            {
                UServer.Broadcast( args.Join( 0 ) );
            }
            return CommandResult.Success();
        }
    }
}
