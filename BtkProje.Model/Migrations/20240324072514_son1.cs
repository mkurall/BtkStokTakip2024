using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BtkProje.Model.Migrations
{
    /// <inheritdoc />
    public partial class son1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblStokCikis_Kullanicilar_GuncelleyenKullaniciId",
                table: "TblStokCikis");

            migrationBuilder.DropForeignKey(
                name: "FK_TblStokCikis_Kullanicilar_OlusturanKullaniciId",
                table: "TblStokCikis");

            migrationBuilder.DropForeignKey(
                name: "FK_TblStokCikis_Musteriler_MusteriId",
                table: "TblStokCikis");

            migrationBuilder.DropForeignKey(
                name: "FK_TblStokCikis_Urunler_UrunId",
                table: "TblStokCikis");

            migrationBuilder.DropForeignKey(
                name: "FK_TblStokGiris_Kullanicilar_GuncelleyenKullaniciId",
                table: "TblStokGiris");

            migrationBuilder.DropForeignKey(
                name: "FK_TblStokGiris_Kullanicilar_OlusturanKullaniciId",
                table: "TblStokGiris");

            migrationBuilder.DropForeignKey(
                name: "FK_TblStokGiris_Tedarikciler_TedarikciId",
                table: "TblStokGiris");

            migrationBuilder.DropForeignKey(
                name: "FK_TblStokGiris_Urunler_UrunId",
                table: "TblStokGiris");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblStokGiris",
                table: "TblStokGiris");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblStokCikis",
                table: "TblStokCikis");

            migrationBuilder.RenameTable(
                name: "TblStokGiris",
                newName: "StokGirisler");

            migrationBuilder.RenameTable(
                name: "TblStokCikis",
                newName: "StokCikislar");

            migrationBuilder.RenameIndex(
                name: "IX_TblStokGiris_UrunId",
                table: "StokGirisler",
                newName: "IX_StokGirisler_UrunId");

            migrationBuilder.RenameIndex(
                name: "IX_TblStokGiris_TedarikciId",
                table: "StokGirisler",
                newName: "IX_StokGirisler_TedarikciId");

            migrationBuilder.RenameIndex(
                name: "IX_TblStokGiris_OlusturanKullaniciId",
                table: "StokGirisler",
                newName: "IX_StokGirisler_OlusturanKullaniciId");

            migrationBuilder.RenameIndex(
                name: "IX_TblStokGiris_GuncelleyenKullaniciId",
                table: "StokGirisler",
                newName: "IX_StokGirisler_GuncelleyenKullaniciId");

            migrationBuilder.RenameIndex(
                name: "IX_TblStokCikis_UrunId",
                table: "StokCikislar",
                newName: "IX_StokCikislar_UrunId");

            migrationBuilder.RenameIndex(
                name: "IX_TblStokCikis_OlusturanKullaniciId",
                table: "StokCikislar",
                newName: "IX_StokCikislar_OlusturanKullaniciId");

            migrationBuilder.RenameIndex(
                name: "IX_TblStokCikis_MusteriId",
                table: "StokCikislar",
                newName: "IX_StokCikislar_MusteriId");

            migrationBuilder.RenameIndex(
                name: "IX_TblStokCikis_GuncelleyenKullaniciId",
                table: "StokCikislar",
                newName: "IX_StokCikislar_GuncelleyenKullaniciId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StokGirisler",
                table: "StokGirisler",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StokCikislar",
                table: "StokCikislar",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StokCikislar_Kullanicilar_GuncelleyenKullaniciId",
                table: "StokCikislar",
                column: "GuncelleyenKullaniciId",
                principalTable: "Kullanicilar",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StokCikislar_Kullanicilar_OlusturanKullaniciId",
                table: "StokCikislar",
                column: "OlusturanKullaniciId",
                principalTable: "Kullanicilar",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StokCikislar_Musteriler_MusteriId",
                table: "StokCikislar",
                column: "MusteriId",
                principalTable: "Musteriler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StokCikislar_Urunler_UrunId",
                table: "StokCikislar",
                column: "UrunId",
                principalTable: "Urunler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StokGirisler_Kullanicilar_GuncelleyenKullaniciId",
                table: "StokGirisler",
                column: "GuncelleyenKullaniciId",
                principalTable: "Kullanicilar",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StokGirisler_Kullanicilar_OlusturanKullaniciId",
                table: "StokGirisler",
                column: "OlusturanKullaniciId",
                principalTable: "Kullanicilar",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StokGirisler_Tedarikciler_TedarikciId",
                table: "StokGirisler",
                column: "TedarikciId",
                principalTable: "Tedarikciler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StokGirisler_Urunler_UrunId",
                table: "StokGirisler",
                column: "UrunId",
                principalTable: "Urunler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StokCikislar_Kullanicilar_GuncelleyenKullaniciId",
                table: "StokCikislar");

            migrationBuilder.DropForeignKey(
                name: "FK_StokCikislar_Kullanicilar_OlusturanKullaniciId",
                table: "StokCikislar");

            migrationBuilder.DropForeignKey(
                name: "FK_StokCikislar_Musteriler_MusteriId",
                table: "StokCikislar");

            migrationBuilder.DropForeignKey(
                name: "FK_StokCikislar_Urunler_UrunId",
                table: "StokCikislar");

            migrationBuilder.DropForeignKey(
                name: "FK_StokGirisler_Kullanicilar_GuncelleyenKullaniciId",
                table: "StokGirisler");

            migrationBuilder.DropForeignKey(
                name: "FK_StokGirisler_Kullanicilar_OlusturanKullaniciId",
                table: "StokGirisler");

            migrationBuilder.DropForeignKey(
                name: "FK_StokGirisler_Tedarikciler_TedarikciId",
                table: "StokGirisler");

            migrationBuilder.DropForeignKey(
                name: "FK_StokGirisler_Urunler_UrunId",
                table: "StokGirisler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StokGirisler",
                table: "StokGirisler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StokCikislar",
                table: "StokCikislar");

            migrationBuilder.RenameTable(
                name: "StokGirisler",
                newName: "TblStokGiris");

            migrationBuilder.RenameTable(
                name: "StokCikislar",
                newName: "TblStokCikis");

            migrationBuilder.RenameIndex(
                name: "IX_StokGirisler_UrunId",
                table: "TblStokGiris",
                newName: "IX_TblStokGiris_UrunId");

            migrationBuilder.RenameIndex(
                name: "IX_StokGirisler_TedarikciId",
                table: "TblStokGiris",
                newName: "IX_TblStokGiris_TedarikciId");

            migrationBuilder.RenameIndex(
                name: "IX_StokGirisler_OlusturanKullaniciId",
                table: "TblStokGiris",
                newName: "IX_TblStokGiris_OlusturanKullaniciId");

            migrationBuilder.RenameIndex(
                name: "IX_StokGirisler_GuncelleyenKullaniciId",
                table: "TblStokGiris",
                newName: "IX_TblStokGiris_GuncelleyenKullaniciId");

            migrationBuilder.RenameIndex(
                name: "IX_StokCikislar_UrunId",
                table: "TblStokCikis",
                newName: "IX_TblStokCikis_UrunId");

            migrationBuilder.RenameIndex(
                name: "IX_StokCikislar_OlusturanKullaniciId",
                table: "TblStokCikis",
                newName: "IX_TblStokCikis_OlusturanKullaniciId");

            migrationBuilder.RenameIndex(
                name: "IX_StokCikislar_MusteriId",
                table: "TblStokCikis",
                newName: "IX_TblStokCikis_MusteriId");

            migrationBuilder.RenameIndex(
                name: "IX_StokCikislar_GuncelleyenKullaniciId",
                table: "TblStokCikis",
                newName: "IX_TblStokCikis_GuncelleyenKullaniciId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblStokGiris",
                table: "TblStokGiris",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblStokCikis",
                table: "TblStokCikis",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TblStokCikis_Kullanicilar_GuncelleyenKullaniciId",
                table: "TblStokCikis",
                column: "GuncelleyenKullaniciId",
                principalTable: "Kullanicilar",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TblStokCikis_Kullanicilar_OlusturanKullaniciId",
                table: "TblStokCikis",
                column: "OlusturanKullaniciId",
                principalTable: "Kullanicilar",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TblStokCikis_Musteriler_MusteriId",
                table: "TblStokCikis",
                column: "MusteriId",
                principalTable: "Musteriler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblStokCikis_Urunler_UrunId",
                table: "TblStokCikis",
                column: "UrunId",
                principalTable: "Urunler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblStokGiris_Kullanicilar_GuncelleyenKullaniciId",
                table: "TblStokGiris",
                column: "GuncelleyenKullaniciId",
                principalTable: "Kullanicilar",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TblStokGiris_Kullanicilar_OlusturanKullaniciId",
                table: "TblStokGiris",
                column: "OlusturanKullaniciId",
                principalTable: "Kullanicilar",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TblStokGiris_Tedarikciler_TedarikciId",
                table: "TblStokGiris",
                column: "TedarikciId",
                principalTable: "Tedarikciler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblStokGiris_Urunler_UrunId",
                table: "TblStokGiris",
                column: "UrunId",
                principalTable: "Urunler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
