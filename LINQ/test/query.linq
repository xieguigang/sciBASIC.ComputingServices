from x as row in "E:\GCModeller\src\runtime\Darwinism\LINQ\test\data.csv"
where x.PeakQuality >= 0.999
select x.LipidIon,  lipidName =x.Class & x.FattyAcid,   x.Class,	x.FattyAcid,	x.Ion,	x.Formula,x.PeakQuality,x."m-Score"
order by  lipidName
take 15