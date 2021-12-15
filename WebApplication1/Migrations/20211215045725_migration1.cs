using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    school_id = table.Column<Guid>(nullable: false),
                    student_status = table.Column<string>(nullable: true),
                    adm_prefix = table.Column<string>(nullable: true),
                    adm_number = table.Column<int>(nullable: true),
                    adm_number_index = table.Column<int>(nullable: false),
                    adm_postfix = table.Column<string>(nullable: true),
                    adm_no = table.Column<string>(nullable: true),
                    tmp_prefix = table.Column<string>(nullable: true),
                    tmp_number = table.Column<int>(nullable: true),
                    tmp_number_index = table.Column<int>(nullable: false),
                    tmp_postfix = table.Column<string>(nullable: true),
                    tmp_no = table.Column<string>(nullable: true),
                    first_name = table.Column<string>(nullable: true),
                    middle_name = table.Column<string>(nullable: true),
                    last_name = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    dob = table.Column<DateTime>(nullable: true),
                    temporary_join_date = table.Column<DateTime>(nullable: true),
                    gender = table.Column<string>(nullable: true),
                    uu_id = table.Column<string>(nullable: true),
                    academic_year = table.Column<string>(nullable: true),
                    special_id = table.Column<string>(nullable: true),
                    guardian_name = table.Column<string>(nullable: true),
                    father_name = table.Column<string>(nullable: true),
                    mother_name = table.Column<string>(nullable: true),
                    terminated_at = table.Column<DateTime>(nullable: false),
                    guardian_id = table.Column<Guid>(nullable: true),
                    student_user_id = table.Column<Guid>(name: "student_user_id ", nullable: true),
                    send_user_details_via = table.Column<string>(nullable: true),
                    create_user_name_by = table.Column<string>(nullable: true),
                    send_user_status = table.Column<bool>(nullable: false, defaultValue: false),
                    user_post_fix_value = table.Column<int>(nullable: false),
                    web_connectivity_student_id = table.Column<int>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: true, defaultValueSql: "transaction_timestamp()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UNIQ_ADMISSION_NUMBER",
                table: "students",
                columns: new[] { "school_id", "adm_no" },
                unique: true,
                filter: "adm_no IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UNIQ_TEMPORARY_NUMBER",
                table: "students",
                columns: new[] { "school_id", "tmp_no" },
                unique: true,
                filter: "tmp_no IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UNIQ_UUID_NUMBER",
                table: "students",
                columns: new[] { "school_id", "uu_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UNIQ_WEB_CONNECTIVITY_STUDENT_ID",
                table: "students",
                columns: new[] { "school_id", "web_connectivity_student_id" },
                unique: true,
                filter: "web_connectivity_student_id IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "students");
        }
    }
}
