ALTER PROCEDURE ObterProdutosPaginado   
@PageNumber int,  
@Pagesize INT  
  
as  
  
begin  
  
  
DECLARE @sql nvarchar(1000)  

IF (@PageNumber <= 0)
	BEGIN
		SET @PageNumber = 1
	END
  
SET  @sql = 'SELECT Id, Nome, Descricao, DataInclusao, DataAlteracao, ValorCompra FROM Produto ORDER BY Id ' +  
  ' OFFSET ' + CONVERT(VARCHAR(10), @Pagesize) + '*'  + '(' + CONVERT(VARCHAR(10), @PageNumber) + '-' + '1) ROWS FETCH NEXT ' +  
  CONVERT(VARCHAR(10), @Pagesize)+ ' ROWS ONLY OPTION (RECOMPILE);';

  --SELECT @SQL
     
  EXEC SP_EXECUTESQL @SQL  
  
    
  
end