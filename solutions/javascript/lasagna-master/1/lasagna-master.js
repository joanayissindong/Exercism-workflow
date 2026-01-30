/// <reference path="./global.d.ts" />
// @ts-check

/**
 * Implement the functions needed to solve the exercise here.
 * Do not forget to export them so they are available for the
 * tests. Here an example of the syntax as reminder:
 *
 * export function yourFunction(...) {
 *   ...
 * }
 */

/**
 * Determines the cooking status based on the remaining time.
 *
 * @param {number} timer
 * @returns {string} the cooking status
 */
export function cookingStatus(timer) {
  if (timer === 0) return 'Lasagna is done.'

  if (timer > 0) return 'Not done, please wait.'

  return 'You forgot to set the timer.'
}

/**
 * Calculates the preparation time based on the number of layers and time per layer.
 *
 * @param {Array<string>} arrayOfLayers
 * @param {number} averageTimePerLayer
 * @returns {number} the total preparation time
 */
export function preparationTime(arrayOfLayers, averageTimePerLayer = 2) {
  return arrayOfLayers.length * averageTimePerLayer;
}

/**
 * Calculates the quantities of ingredients needed.
 *
 * @param {Array<string>} arrayOfLayers
 * @returns {object} the quantities of ingredients
 */
export function quantities(arrayOfLayers) {
  const noodles = arrayOfLayers.filter(layer => layer === 'noodles').length
  const sauce = arrayOfLayers.filter(layer => layer === 'sauce').length

  return { noodles: noodles * 50, sauce: sauce * 0.2 }
}

/**
 * Adds a secret ingredient from a friend's recipe to your own recipe.
 * Takes the last ingredient from the friend's list and adds it to the end of your list.
 *
 * @param {string[]} friendsList - An array of ingredients from a friend's recipe
 * @param {string[]} myList - An array of ingredients from your own recipe
 * @returns {void}
 */
export function addSecretIngredient(friendsList, myList) {
  const secretIngredient = friendsList.at(-1)
  if (secretIngredient !== undefined) myList.push(secretIngredient)
}

/**
 * Scales a recipe based on the number of portions.
 *
 * @param {Record<string, number>} recipe - An object with ingredient names as keys and quantities as values
 * @param {number} numberOfPortions - The number of portions to scale the recipe for
 * @returns {Record<string, number>} the scaled recipe
 */
export function scaleRecipe(recipe, numberOfPortions) {
  const scaledRecipe = { ...recipe }

  for (const ingredient in scaledRecipe) {
    scaledRecipe[ingredient] = (scaledRecipe[ingredient] * numberOfPortions) / 2
  }

  return scaledRecipe
}