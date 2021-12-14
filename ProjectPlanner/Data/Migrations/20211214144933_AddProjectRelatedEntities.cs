using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectPlanner.Data.Migrations
{
    public partial class AddProjectRelatedEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Column_Project_ProjectId",
                table: "Column");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Ticket_TicketId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Project_AspNetUsers_MyUserId",
                table: "Project");

            migrationBuilder.DropForeignKey(
                name: "FK_Tag_Ticket_TicketId",
                table: "Tag");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Column_ColumnId",
                table: "Ticket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ticket",
                table: "Ticket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tag",
                table: "Tag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Project",
                table: "Project");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item",
                table: "Item");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Column",
                table: "Column");

            migrationBuilder.RenameTable(
                name: "Ticket",
                newName: "Tickets");

            migrationBuilder.RenameTable(
                name: "Tag",
                newName: "Tags");

            migrationBuilder.RenameTable(
                name: "Project",
                newName: "Projects");

            migrationBuilder.RenameTable(
                name: "Item",
                newName: "Items");

            migrationBuilder.RenameTable(
                name: "Column",
                newName: "Columns");

            migrationBuilder.RenameIndex(
                name: "IX_Ticket_ColumnId",
                table: "Tickets",
                newName: "IX_Tickets_ColumnId");

            migrationBuilder.RenameIndex(
                name: "IX_Tag_TicketId",
                table: "Tags",
                newName: "IX_Tags_TicketId");

            migrationBuilder.RenameIndex(
                name: "IX_Project_MyUserId",
                table: "Projects",
                newName: "IX_Projects_MyUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Item_TicketId",
                table: "Items",
                newName: "IX_Items_TicketId");

            migrationBuilder.RenameIndex(
                name: "IX_Column_ProjectId",
                table: "Columns",
                newName: "IX_Columns_ProjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tags",
                table: "Tags",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projects",
                table: "Projects",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Columns",
                table: "Columns",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Columns_Projects_ProjectId",
                table: "Columns",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Tickets_TicketId",
                table: "Items",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_AspNetUsers_MyUserId",
                table: "Projects",
                column: "MyUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Tickets_TicketId",
                table: "Tags",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Columns_ColumnId",
                table: "Tickets",
                column: "ColumnId",
                principalTable: "Columns",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Columns_Projects_ProjectId",
                table: "Columns");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Tickets_TicketId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_AspNetUsers_MyUserId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Tickets_TicketId",
                table: "Tags");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Columns_ColumnId",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tags",
                table: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Projects",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Columns",
                table: "Columns");

            migrationBuilder.RenameTable(
                name: "Tickets",
                newName: "Ticket");

            migrationBuilder.RenameTable(
                name: "Tags",
                newName: "Tag");

            migrationBuilder.RenameTable(
                name: "Projects",
                newName: "Project");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "Item");

            migrationBuilder.RenameTable(
                name: "Columns",
                newName: "Column");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_ColumnId",
                table: "Ticket",
                newName: "IX_Ticket_ColumnId");

            migrationBuilder.RenameIndex(
                name: "IX_Tags_TicketId",
                table: "Tag",
                newName: "IX_Tag_TicketId");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_MyUserId",
                table: "Project",
                newName: "IX_Project_MyUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_TicketId",
                table: "Item",
                newName: "IX_Item_TicketId");

            migrationBuilder.RenameIndex(
                name: "IX_Columns_ProjectId",
                table: "Column",
                newName: "IX_Column_ProjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ticket",
                table: "Ticket",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tag",
                table: "Tag",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Project",
                table: "Project",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item",
                table: "Item",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Column",
                table: "Column",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Column_Project_ProjectId",
                table: "Column",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Ticket_TicketId",
                table: "Item",
                column: "TicketId",
                principalTable: "Ticket",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_AspNetUsers_MyUserId",
                table: "Project",
                column: "MyUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tag_Ticket_TicketId",
                table: "Tag",
                column: "TicketId",
                principalTable: "Ticket",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Column_ColumnId",
                table: "Ticket",
                column: "ColumnId",
                principalTable: "Column",
                principalColumn: "Id");
        }
    }
}
