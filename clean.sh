find . -type d -name "bin" -o -type d -name "obj" -o -type d -name "packages" -o -type d -iname "*generated" | xargs rm -rf