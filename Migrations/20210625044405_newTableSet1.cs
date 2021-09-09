using Microsoft.EntityFrameworkCore.Migrations;

namespace CapstoneProject.Migrations
{
    public partial class newTableSet1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "b742dd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ae3a710-2498-4217-9911-b71c562384c2", "AQAAAAEAACcQAAAAEAEqO2UGd0dmSQaZ41o+4SjGwWEPPoDslpO1zwJrYCRISzIazJsZCQns3zs8zn7clA==", "d87ea233-c7d7-49ec-8783-17519e925022" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "b74dd234-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "230c5398-31cc-449e-ba0a-146b154440e8", "AQAAAAEAACcQAAAAEGhJ/GgIvAFZXhhihtDT3N76bsow3JBkrItzw4dexupqfVblas4/utdNwFxbPfUjcA==", "d8df0585-2a63-4fae-8c6f-bf300e8134b7" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12b8d113-546a-41d4-8376-531c606761e2", "AQAAAAEAACcQAAAAEAzga7to0Vny9KddU2odX3sNJFeIsnrYCjPbEMBGC1e//ZurTQVSPDjkC+hK+qPIHQ==", "10a34931-4bf4-40bd-840e-df2eca55558c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "b742dd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4573bd15-2458-4db2-827a-b69d2f056073", "AQAAAAEAACcQAAAAEDt+zOUVOnqPSAugDOWd6cS8TFKZxQabH+ZgxvqQFcn/AF/phuu7BBoD56R8ZazY0A==", "f490e890-6d92-43f6-a63d-ffe3635840ee" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "b74dd234-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ce266ec-1d10-4429-a5dd-40c41c1cc118", "AQAAAAEAACcQAAAAEGzF5gS6n/Nz06na5xgPqxJ/DVs0JNMYb0Kg78jVt4nymuU+K1+ocw4l1/3Yg7oujA==", "d5c23687-cdf7-435b-8065-04e9a44aa6e1" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a96d671-3f39-49e9-a35d-12f9e94d7cdc", "AQAAAAEAACcQAAAAEPCF11LYQUsJxil/fPU0/cVOlVddItfIY6MAeQKmS+JaktTSu+sbFBGLXIxosyALjw==", "cb3e5ad5-1cd3-4615-9c83-1008defbb1f7" });
        }
    }
}
