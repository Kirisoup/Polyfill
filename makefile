.PHONY: pack
pack:
	if defined DIR ( \
	    dotnet pack -p:PackDir=$(shell for %%A in ("$(DIR)") do @echo %%~fA) \
	) else ( \
	    dotnet pack \
	)
