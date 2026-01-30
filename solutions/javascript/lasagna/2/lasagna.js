// @ts-check
//
// ☝🏽 The line above enables type checking for this file. Various IDEs interpret
// the @ts-check directive. It will give you helpful autocompletion on the web
// and supported IDEs when implementing this exercise. You don't need to
// understand types, JSDoc, or TypeScript in order to complete this JavaScript
// exercise, and can completely ignore this comment block and directive.

// 👋🏽 Hi there!
//
// On the JavaScript track we provide you with stubs. These stubs provide a
// starting point to solving the exercise.
//
// In general, each variable/constant and each declared function will have a
// JSDoc comment block above it, explaining what the variable/constant holds or
// the function is supposed to accomplish.
//
// 💡 Often, the JSDoc comment blocks have annotations, such as @param and
// @returns which are usually highlighted with a different color if the IDE
// you're in recognizes them. It's these annotations that are used when
// referring to the constant, variable, or function from somewhere else that
// IDEs display.
//
// You don't need to write these yourself; it is not expected in idiomatic
// JavaScript, but some companies and style-guides do enforce them.
//
// 💡 You're allowed to completely clear a stub before you get started. Often
// we recommend using the stub, because they are already set-up correctly to
// work with the tests, which you can find in ./lasagna.spec.js
//
// Good luck preparing some lasagna!

/**
 * The number of minutes it takes to prepare a single layer.
 */
const PREPARATION_MINUTES_PER_LAYER = 2;

/**
 * Define the expected oven time in minutes
 */
export const EXPECTED_MINUTES_IN_OVEN = 40;

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

/**
 * Determines the number of minutes the lasagna still needs to remain in the
 * oven to be properly prepared.
 *
 * @param {number} actualMinutesInOven
 * @returns {number} the number of minutes remaining
 */
export function remainingMinutesInOven(actualMinutesInOven) {
  return EXPECTED_MINUTES_IN_OVEN - actualMinutesInOven;
}

/**
 * Given a number of layers, determines the total preparation time.
 *
 * @param {number} numberOfLayers
 * @returns {number} the total preparation time
 */
export function preparationTimeInMinutes(numberOfLayers) {
  return numberOfLayers * PREPARATION_MINUTES_PER_LAYER;
}

/**
 * Calculates the total working time. That is, the time to prepare all the layers
 * of lasagna, and the time already spent in the oven.
 *
 * @param {number} numberOfLayers
 * @param {number} actualMinutesInOven
 * @returns {number} the total working time
 */
export function totalTimeInMinutes(numberOfLayers, actualMinutesInOven) {
  return preparationTimeInMinutes(numberOfLayers) + actualMinutesInOven;
}
