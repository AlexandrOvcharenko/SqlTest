using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ConsoleApp1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SR_directory_country",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    value_eng = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    value_abbr = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SR_directory_country", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SR_directory_port",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    code_port = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    name_ukr = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    name_eng = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    position_capitan_ukr = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    position_capitan_eng = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    phone = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    email = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    is_disable = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SR_directory_port", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SR_directory_rank",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    name_ukr = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    name_eng = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    is_disable = table.Column<bool>(type: "boolean", nullable: false),
                    price = table.Column<double>(type: "double precision", nullable: true),
                    direction_id = table.Column<int>(type: "integer", nullable: true),
                    type_document_id = table.Column<int>(type: "integer", nullable: true),
                    type_rank_id = table.Column<int>(type: "integer", nullable: true),
                    is_dkk = table.Column<bool>(type: "boolean", nullable: false),
                    priority = table.Column<int>(type: "integer", nullable: true),
                    uuid = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SR_directory_rank", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SR_directory_statusdocument",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    name_ukr = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    name_eng = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    is_disable = table.Column<bool>(type: "boolean", nullable: false),
                    for_service = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    can_user_change = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SR_directory_statusdocument", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SR_directory_typedocument",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    name_ukr = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    name_eng = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    code = table.Column<int>(type: "integer", nullable: true),
                    is_disable = table.Column<bool>(type: "boolean", nullable: false),
                    for_service = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    price = table.Column<double>(type: "double precision", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SR_directory_typedocument", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SR_QUALIF_DOCS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false, comment: "Идентификатор записи"),
                    DN_NUMBER = table.Column<int>(type: "integer", nullable: false, comment: "Составной номер документа. Номер документа"),
                    DN_YAER = table.Column<int>(type: "integer", nullable: false, comment: "Составной номер документа. Год выдачи документа"),
                    DN_PORT = table.Column<int>(type: "integer", nullable: false, comment: "Составной номер документа. Код порта выдачи документа"),
                    DT_ISSUE = table.Column<DateTime>(type: "date", nullable: false, comment: "Дата выдачи документа"),
                    D_TYPE = table.Column<int>(type: "integer", nullable: false, comment: "Тип документа"),
                    D_STATUS = table.Column<int>(type: "integer", nullable: false, comment: "Статус документа"),
                    RANK = table.Column<int>(type: "integer", nullable: false, comment: "Звание"),
                    SF_SURNAME = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false, comment: "Фамилия моряка (укр.)"),
                    SF_NAME = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false, comment: "Имя моряка (укр.)"),
                    SF_PATRONYMIC = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: true, comment: "Отчество (укр.)"),
                    SF_FN = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false, comment: "Seafarer first name"),
                    SF_LN = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false, comment: "Seafarer last name"),
                    SF_DOB = table.Column<DateTime>(type: "date", nullable: false, comment: "Дата рождения"),
                    SF_CS = table.Column<int>(type: "integer", nullable: true, comment: "Гражданство"),
                    PORT_CAPITAN = table.Column<int>(type: "integer", nullable: true, comment: "Капитан порта выдавшего документ"),
                    SB_LETER = table.Column<string>(type: "character varying(3)", unicode: false, maxLength: 3, nullable: true, comment: "Серия бланка строгой отчетности "),
                    SB_NUMBER = table.Column<int>(type: "integer", nullable: true, comment: "Номер бланка строгой отчетности")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SR_QUALIF_DOCS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SR_QUALIF_DOCS_SR_directory_country",
                        column: x => x.SF_CS,
                        principalTable: "SR_directory_country",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SR_QUALIF_DOCS_SR_directory_port",
                        column: x => x.DN_PORT,
                        principalTable: "SR_directory_port",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SR_QUALIF_DOCS_SR_directory_rank",
                        column: x => x.RANK,
                        principalTable: "SR_directory_rank",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SR_QUALIF_DOCS_SR_directory_statusdocument",
                        column: x => x.D_STATUS,
                        principalTable: "SR_directory_statusdocument",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SR_QUALIF_DOCS_SR_directory_typedocument",
                        column: x => x.D_TYPE,
                        principalTable: "SR_directory_typedocument",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SR_QD_SERVICE_INFO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    QD_ID = table.Column<int>(type: "integer", nullable: false),
                    LINK = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: true),
                    MR_ID = table.Column<int>(type: "integer", nullable: true),
                    PR_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SR_QD_SERVICE_INFO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SR_QD_SERVICE_INFO_SR_QUALIF_DOCS",
                        column: x => x.QD_ID,
                        principalTable: "SR_QUALIF_DOCS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SR_QD_SERVICE_INFO_QD_ID",
                table: "SR_QD_SERVICE_INFO",
                column: "QD_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SR_QUALIF_DOCS_D_STATUS",
                table: "SR_QUALIF_DOCS",
                column: "D_STATUS");

            migrationBuilder.CreateIndex(
                name: "IX_SR_QUALIF_DOCS_D_TYPE",
                table: "SR_QUALIF_DOCS",
                column: "D_TYPE");

            migrationBuilder.CreateIndex(
                name: "IX_SR_QUALIF_DOCS_DN_PORT",
                table: "SR_QUALIF_DOCS",
                column: "DN_PORT");

            migrationBuilder.CreateIndex(
                name: "IX_SR_QUALIF_DOCS_RANK",
                table: "SR_QUALIF_DOCS",
                column: "RANK");

            migrationBuilder.CreateIndex(
                name: "IX_SR_QUALIF_DOCS_SF_CS",
                table: "SR_QUALIF_DOCS",
                column: "SF_CS");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SR_QD_SERVICE_INFO");

            migrationBuilder.DropTable(
                name: "SR_QUALIF_DOCS");

            migrationBuilder.DropTable(
                name: "SR_directory_country");

            migrationBuilder.DropTable(
                name: "SR_directory_port");

            migrationBuilder.DropTable(
                name: "SR_directory_rank");

            migrationBuilder.DropTable(
                name: "SR_directory_statusdocument");

            migrationBuilder.DropTable(
                name: "SR_directory_typedocument");
        }
    }
}
