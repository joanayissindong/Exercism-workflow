#!/usr/bin/env bash
main() {
    input="$1"
    reversed=""

    #Boucle à rebours sur les caractères
    for (( i=${#input} - 1; i >= 0; i-- )); do
        reversed="$reversed${input:$i:1}"
    done

    echo "$reversed"
}

main "$@"